function confirmDelete(id, isDeletePressed) {
    let deleteBtn_Id = "deleteBtn_" + id;
    let confirmSpan_Id = "confirmSpan_" + id;

    if (isDeletePressed) {
        $("#" + deleteBtn_Id).hide();
        $("#" + confirmSpan_Id).show();
    } else {
        $("#" + deleteBtn_Id).show();
        $("#" + confirmSpan_Id).hide();
    }
}
