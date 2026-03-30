let modal = document.querySelector(".modal-popup");
let overlay = document.querySelector(".overlay");

let addbutton = document.getElementById("addbutton");


const Displayaddmodal = function(id)
{
   
   modal.classList.remove("hidden");
   overlay.classList.remove("hidden");
}

const CloseModal = function()
{
    modal.classList.add("hidden");
    overlay.classList.add("hidden");
}

addbutton.addEventListener("click", (e) => 
{
    console.log(e.target.id);
    Displayaddmodal(e.target.id);
});

overlay.addEventListener("click",CloseModal);
