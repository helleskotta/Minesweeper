﻿
// Klickfunktion bakgrundsfärg
function tdclick(tdID, isMine) {
    
    //var mineOrNot = Math.floor(Math.random() * 3 + 1);
    console.log(isMine);
    console.log(tdID);

    if (isMine == true) {
        $("#" + tdID).css("background", "red")
    }

    else if (isMine == false){
        $("#" + tdID).css("background", "green")
    }

    else {
        alert("FACK")
    }
};