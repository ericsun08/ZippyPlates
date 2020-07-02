const controls=document.querySelector(".controls")
const slide = document.querySelector(".slide");
const allBox = slide.children;
const slidewidth = slide.offsetWidth;
const margin = 10;
var items = 0;
var totalItems = 0;
var jumpSlideWidth = 0;



responsive = [
    {breakPoint:{width:0,item:1}}, 
    {breakPoint:{width: 600,item:2}},
    {breakPoint:{width:1000,item:6}}
]

function load() {
    for (let i = 0; i < responsive.length; i++) {
        if (window.innerWidth > responsive[i].breakPoint.width) {
            items = responsive[i].breakPoint.item
        }
    }
    start();
}

function start() {
    var totalItemsWidth=0
    for (let i = 0; i < allBox.length; i++) {
        allBox[i].style.width = (slidewidth / items)-margin + "px";
        allBox[i].style.margin = (margin / 2) + "px";
        totalItemsWidth += slidewidth / items;
        totalItems++;
    }
    slide.style.width = totalItemsWidth + "px"

    
    const allSlides = Math.ceil(totalItems / items);
    const ul = document.querySelector("ul");
    for (let i = 1; i <= allSlides; i++) {
        const li = document.querySelector("li");
                li.id = i;
                li.innerHTML = i;
                li.setAttribute("onclick", "controlSlides(this)");
            ul.appendChild(li);
            if (i == 1) {
                li.className = "active";
            }

        }
        controls.appendChild(ul);
    
}

function controlSlides(ele) {
    const ul = controls.children;
    const li = ul[0].children
    var active;
    for (let i = 0; i < li.length; i++) {
        if (li[i].className == "active") {
            active = i;
            li[i].className=""
        }
    }
    ele.className = "active";
    var numb = (ele.id - 1) - active;
    jumpSlideWidth = jumpSlideWidth + (slidewidth * numb);
    slide.style.marginLeft = -jumpSlideWidth + "px";

}

window.onload = load();



