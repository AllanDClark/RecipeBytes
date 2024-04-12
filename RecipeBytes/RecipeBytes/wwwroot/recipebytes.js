$(document).ready(function(){
  // Toggle Bootstrap theme attr
  $('body').on('click','.theme-toggler', function(event) {
    event.preventDefault();

    $(this).toggleClass("btn-outline-dark btn-outline-light");

    if ($("html").attr("data-bs-theme") == "light") {
      $("html").attr("data-bs-theme","dark");
      $(this).html('☾ Dark Mode');
    } else {
      $("html").attr("data-bs-theme","light");
      $(this).html('☀︎ Light Mode');
    }
  });

    $("#filterInput").on("keyup", function () {
        var value = $(this).val().toLowerCase();
        $("#recipeTable tr").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        });
    });
});
