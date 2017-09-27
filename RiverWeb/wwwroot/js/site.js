// Write your Javascript code.
$(document).ready(function () {
  $('[data-toggle="offcanvas"]').click(function () {
    $('.row-offcanvas').toggleClass('active')
  });
});

//DataTable
$(document).ready(function() {
    $('#Stamps').DataTable();
} );