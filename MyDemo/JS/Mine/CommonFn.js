//==========js点击选择文本的方法==========
//eleID:控件ID
function selectText(eleID) {
    if (document.selection) {
        var range = document.body.createTextRange();
        range.moveToElementText(document.getElementById(eleID));
        range.select();
    } else if (window.getSelection) {
        var range = document.createRange();
        range.selectNode(document.getElementById(eleID));
        window.getSelection().addRange(range);
    }
}

function blockedOpen() {
    var bLocked = true;
    try {
        var win = window.open("https://www.baidu.com/", "mywin");
        if (win != null) {
            bLocked = false;
        }        
    } catch (e) {

    }
    return bLocked;
}