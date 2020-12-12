function confirmDelete(uniqueId, binDelete) {
    var deleteSpan = "supprimeSpan_" + uniqueId
    var confirmSpan = "confirmeSpan_" + uniqueId

    if (binDelete) {
        $('#' + deleteSpan).hide();
        $("#" + confirmSpan).show();
    } else {
        $('#' + deleteSpan).show();
        $("#" + confirmSpan).hide();
    }
}