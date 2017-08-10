
// Klickfunktion
function tdclick(tdID) {

    var mineOrNot = Math.floor(Math.random() * 3 + 1);
    console.log(mineOrNot);

    if (mineOrNot == 1) {
        $("#" + tdID).css("background", "red")
    }

    else{

        $("#" + tdID).css("background", "green")
    }
};