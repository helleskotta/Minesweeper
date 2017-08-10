// Klickfunktion bakgrundsfärg
// function tdclick(tdID, isMine, x, y) {
    //var mineOrNot = Math.floor(Math.random() * 3 + 1);
    //console.log(isMine);
    //console.log(tdID);

    //if (isMine === true) {
    //    $("#" + tdID).css("background", "green");
    //}

    //else if (isMine === false) {
    //    $("#" + tdID).css("background", "red");
    //}

    //else {
    //    alert("FACK");
    //}

    function tdclick(tdID, isMine, x, y) {
    window.location.href = "index.aspx?action=click&x=" + x + "&y=" + y;
}