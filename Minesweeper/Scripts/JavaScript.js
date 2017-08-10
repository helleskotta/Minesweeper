
// Klickfunktion bakgrundsfärg
function tdclick(tdID, isMine) {

    //var mineOrNot = Math.floor(Math.random() * 3 + 1);
    var True = true;
    var False = false;
    console.log(mineOrNot);

    if (isMine) {
        $("#" + tdID).css("background", "red")
    }

    else{
        $("#" + tdID).css("background", "green")
    }
};