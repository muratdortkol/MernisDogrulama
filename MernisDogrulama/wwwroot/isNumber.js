function isNumberKey(evt) {
    var charCode = (evt.which) ? evt.which : event.keyCode;
    if (charCode != 46 && charCode > 31
        && (charCode < 48 || charCode > 57))
        return false;

    return true;
}

function isLetterKey(evt) {
    
    var charCode = (evt.which) ? evt.which : event.keyCode;
    if (((charCode <= 93 && charCode >= 65) || (charCode <= 122 && charCode >= 97) ||
        charCode == 8) || charCode == 350 || charCode == 351 || charCode == 304 || charCode == 286 ||
        charCode == 287 || charCode == 231 || charCode == 199 || charCode == 305 || charCode == 214 ||
        charCode == 246 || charCode == 220 || charCode == 252) {
            return true;
        }
        return false;
    
};