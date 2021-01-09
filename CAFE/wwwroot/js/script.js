var itemBox, cartCont;

window.onload = function () {
    itemBox = document.querySelectorAll('.item');
    cartCont = document.getElementById('cart_content');
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
    if (cartData !== null) {
        totalItems = '<table class="shopping_list"><tr><th>Наименование</th><th>Цена</th><th>Кол-во</th></tr>';
        for (var items in cartData) {
            totalItems += '<tr>';
            for (var i = 0; i < cartData[items].length; i++) {
                totalItems += '<td>' + cartData[items][i] + '</td>';
            }
            totalItems += '</tr>';
        }
        totalItems += '</table>';
        cartCont.innerHTML = totalItems;
    } else {
        cartCont.innerHTML = 'В корзине пусто!';
    }
    return false;
}