const upButton = document.querySelector("#up");
const downButton = document.querySelector("#down");
const leftButton = document.querySelector("#left");
const rightButton = document.querySelector("#right");
const centerButton = document.querySelector("#center");
var buttons = [["w","ArrowUp"],["s","ArrowDown"],["a","ArrowLeft"],["d","ArrowRight"],["Enter","Enter"]];
const sendMove = (key) => {
   console.log(key);
    fetch("/api/move",{
        headers: {
          'Accept': 'application/json',
          'Content-Type': 'application/json'
        },
        method: "POST",
        body: JSON.stringify({key})
    })     
};

const addClick = (element, post) => element.addEventListener("click",() => sendMove(post));

addClick(upButton, "ArrowUp");
addClick(downButton, "ArrowDown");
addClick(leftButton, "ArrowLeft");
addClick(rightButton, "ArrowRight");
addClick(centerButton, "Enter");
document.addEventListener("keydown", (key) => 
 buttons.forEach(function(item,count){
		 if(item[0] == key.key) sendMove(item[1]);
		 else if(item[1] == key.key) sendMove(key.key);
 }));

function settings(){
	if (document.getElementById("dropdown-menu").className.indexOf(' show') > -1){
		var obj = document.getElementsByClassName("input_settings")
		for(let i = 0; i < obj.length; i++)	buttons[i][0] = obj[i].value;
	}
	else{
	document.getElementById("up_setting").value = buttons[0][0];
	document.getElementById("down_setting").value = buttons[1][0];
	document.getElementById("left_setting").value = buttons[2][0];
	document.getElementById("right_setting").value = buttons[3][0];
	document.getElementById("enter_setting").value = buttons[4][0];
	}
}


