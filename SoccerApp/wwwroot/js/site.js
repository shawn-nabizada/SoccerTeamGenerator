document.addEventListener("DOMContentLoaded", function () {
    const selectAllCheckbox = document.getElementById("selectAll");
    const playerCheckboxes = document.querySelectorAll(".player-checkbox");

    if (selectAllCheckbox) {
        selectAllCheckbox.addEventListener("change", function () {
            const isChecked = this.checked;
            playerCheckboxes.forEach(cb => {
                cb.checked = isChecked;
            });
        });
    }

    playerCheckboxes.forEach(cb => {
        cb.addEventListener("change", function() {
            if (!this.checked) {
                if (selectAllCheckbox) selectAllCheckbox.checked = false;
            }
        });
    });
});