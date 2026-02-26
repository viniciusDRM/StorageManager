let modal = document.querySelector(".modal-popup")
let overlay = document.querySelector(".overlay");

let button = document.getElementById("addbutton");


const Displaymodal =  function()
{
    modal.classList.remove("hidden");
    overlay.classList.remove("hidden");
}

const CloseModal = function()
{
    modal.classList.add("hidden");
    overlay.classList.add("hidden");
}

button.addEventListener("click", Displaymodal);

overlay.addEventListener("click",CloseModal);
