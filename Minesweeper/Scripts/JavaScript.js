
// Klickfunktion bakgrundsfärg
function tdclick(tdID, isMine) {
    
    //var mineOrNot = Math.floor(Math.random() * 3 + 1);
    console.log(isMine);

    if (isMine) {
        $("#" + tdID).css("background", "red")
    }

    else{
        $("#" + tdID).css("background", "green")
    }
};