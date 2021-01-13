var itemBox, cart;

window.onload = function () {
    itemBox = document.querySelectorAll('.item');
    cart = document.getElementById('cart_content');
    for (var i = 0; i < itemBox.length; i++) {
        addEvent(itemBox[i].querySelector('.add_item'), 'click', addToCart);
    }
    openCart();
};

function addEvent(elem, type, handler) {
    if (elem.addEventListener) {
        elem.addEventListener(type, handler, false);
    } else {
        elem.attachEvent('on' + type, function () { handler.call(elem); });
    }
    return false;
}

function getCartData() {
    return JSON.parse(localStorage.getItem('cart'));
}

function setCartData(o) {
    localStorage.setItem('cart', JSON.stringify(o));
    return false;
}

function addToCart(e) {
    this.disabled = true; 
    var cartData = getCartData() || {}, 
        parentBox = this.parentNode, 
        itemId = this.getAttribute('data-id'), 
        itemTitle = parentBox.querySelector('.item-title').innerHTML,
        itemPrice = parentBox.querySelector('.item-price').innerHTML; 
    if (cartData.hasOwnProperty(itemId)) {
        cartData[itemId].quantity += 1;
    } else {
        let i = {
            name: itemTitle,
            price: itemPrice,
            quantity: 1
        };
        cartData[itemId] = i;
    }
    if (!setCartData(cartData)) { 
        this.disabled = false;
    }
    return false;
}


function openCart() {
    var cartData = getCartData(),
        totalItems = '';
    var totalCount = 0,
        totalSum = 0;
    if (cartData !== null) {
        totalItems = '<table class="shopping_list"><tr><th class="namesss">Имя</th><th class="cena">Цена</th><th class="sss">Кол-во</th></tr>';
        for (var item in cartData) {
            totalItems += '<tr>';
            totalItems += '<td class="f">' + cartData[item].name + '</td><td class="f">' + cartData[item].price + '</td><td class="ff"><span class="minus_item" my_catalog_data-id="' + item.name + '" onclick="dob(this, ' + item + ')"><strong>-</strong></span><span class="test" id="' + item + '">' + cartData[item].quantity + '</span><span class="plus_item" my_catalog_data-id="' + item + '" onclick="dob(this, ' + item + ')"><strong>+</strong></span></td>';
            totalSum += cartData[item].price * cartData[item].quantity;
            totalCount += cartData[item].quantity;
        }
        totalItems += '</td>';
        totalItems += '</tr>';
        totalItems += '<tr><td class="ss"><strong>Итого</strong></td><td class="ss"><strong><span id="total_sum"><span id="summ">' + totalSum + '</span></span> &#8381</strong></td><td class="ss"><strong><span id="total_count"><span id="ht">' + totalCount + '</span></span> шт.</strong></td></tr>';
        totalItems += '<table>';
        cart.innerHTML = totalItems;
    } else {
        cart.innerHTML = 'В корзине пусто!';
    }

    return false;
}


function dob(e, itemId) {
    let obj = JSON.parse(localStorage.getItem('cart'));
    let price = 0;
    let count = 0;
    if (e.className === 'plus_item') {

        if (obj.hasOwnProperty(itemId)) {

            obj[itemId].quantity += 1;
            localStorage.setItem('cart', JSON.stringify(obj));
            document.getElementById(itemId).innerHTML = obj[itemId].quantity;
            for (let key in obj) {
                price += obj[key].price * obj[key].quantity
                count += obj[key].quantity
            }
            document.getElementById('summ').innerHTML = price
            document.getElementById('ht').innerHTML = count
        }
    }
    else if (e.className === 'minus_item') {

        if (obj.hasOwnProperty(itemId)) {
            obj[itemId].quantity -= 1;
            if (obj[itemId].quantity < 0) {
                obj[itemId].quantity = 0;
            }
            localStorage.setItem('cart', JSON.stringify(obj));
            document.getElementById(itemId).innerHTML = obj[itemId].quantity;
            for (let key in obj) {
                price -= obj[key].price * obj[key].quantity
                count -= obj[key].quantity
            }
            document.getElementById('ht').innerHTML = Math.abs(count)
            document.getElementById('summ').innerHTML = Math.abs(price)
        }
    }
}
function sendData() {
    let cart = document.getElementById('clear_cart')
    let cartData = getCartData();
    var pust = document.getElementById('pust');
    /*if (cartData === null) {
        pust.addEventListener('click', function (event) {
            event.preventDefault();
            alert('Корзина пуста');
        });
    }*/
    //else {
        let reqBody = {
            items: []
        }
        for (var item in cartData) {
            let i = {
                id: item,
                name: cartData[item].name,
                price: cartData[item].price,
                quantity: cartData[item].quantity
            };
            reqBody.items.push(i)   
        }
        
        let json = JSON.stringify(reqBody);
        console.log(json)
        let request = new XMLHttpRequest();
        request.open("POST", "/cart", true);
        request.setRequestHeader("Content-Type", "application/json");
        request.send(json);
        localStorage.removeItem('cart');
        cart.innerHTML = 'Корзина очищена.'
    }
};