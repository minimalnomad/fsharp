function update_tax_dom(){
    set_tax_dom(calc_tax(shopping_cart_total));
}

function calc_tax(amount){
    return amount * 0.10;
}