function confirmDelete(id, isDeletePressed) {
    let deleteSpan_Id = "deleteSpan_" + id;
    let confirmSpan_Id = "confirmSpan_" + id;

    console.log(deleteSpan_Id);
    console.log(confirmSpan_Id);

    if (isDeletePressed) {
        $("#" + deleteSpan_Id).hide();
        $("#" + confirmSpan_Id).show();
    } else {
        $("#" + deleteSpan_Id).show();
        $("#" + confirmSpan_Id).hide();
    }
}
