var itemBox, cart;

window.onload = function () {
    itemBox = document.querySelectorAll('.item');
    cart = document.getElementById('cart_content');
    for (var i = 0; i < itemBox.length; i++) {
        console.log(i)
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
        cartData[itemId][2] += 1;
    } else {
        cartData[itemId] = [itemTitle, itemPrice, 1];
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
        totalItems = '<table class="shopping_list"><tr><th>Имя</th><th class="sss cena">Цена</th><th class="sss">Кол-во</th></tr>';
        for (var items in cartData) {
            totalItems += '<tr>';
            console.log(cartData[items]);
            for (var i = 0; i < cartData[items].length; i++) {
                if (i === 2)
                    totalItems += '<td><span class="minus_item" my_catalog_data-id="' + items + '" onclick="dob(this, ' + items + ')"><strong>-</strong></span><span id="' + items + '">' + cartData[items][i] + '</span><span class="plus_item" my_catalog_data-id="' + items + '" onclick="dob(this, ' + items + ')"><strong>+</strong></span></td>';
                else {
                    totalItems += '<td>' + cartData[items][i] + '</td>'
                }
            }
            totalSum += cartData[items][1] * cartData[items][2];
            totalCount += cartData[items][2];
            totalItems += '</td>';
            totalItems += '</tr>';
        }
        totalItems += '<tr><td class="sss"><strong>Итого</strong></td><td class="sss"><strong><span id="total_sum"><span id="summ">' + totalSum + '</span></span> &#8381</strong></td><td class="sss"><strong><span id="total_count"><span id="ht">' + totalCount + '</span></span> шт.</strong></td></tr>';
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

            obj[itemId][2] += 1;
            localStorage.setItem('cart', JSON.stringify(obj));
            document.getElementById(itemId).innerHTML = obj[itemId][2];
            for (let key in obj) {
                price += obj[key][1] * obj[key][2]
                count += obj[key][2]
            }
            document.getElementById('summ').innerHTML = price
            document.getElementById('ht').innerHTML = count
        }
    }
    else if (e.className === 'minus_item') {

        if (obj.hasOwnProperty(itemId)) {
            obj[itemId][2] -= 1;
            if (obj[itemId][2] < 0) {
                obj[itemId][2] = 0;
            }
            localStorage.setItem('cart', JSON.stringify(obj));
            document.getElementById(itemId).innerHTML = obj[itemId][2];
            for (let key in obj) {
                price -= obj[key][1] * obj[key][2]
                count -= obj[key][2]
            }
            document.getElementById('ht').innerHTML = Math.abs(count)
            document.getElementById('summ').innerHTML = Math.abs(price)
        }
    }
}