
// Klickfunktion bakgrundsfärg
function tdclick(tdID, isMine) {
    
    //var mineOrNot = Math.floor(Math.random() * 3 + 1);
    console.log(isMine);
    console.log(tdID);

    if (isMine == 'true') {
        $("#" + tdID).css("background", "red")
    }

    else{
        $("#" + tdID).css("background", "green")
    }
};