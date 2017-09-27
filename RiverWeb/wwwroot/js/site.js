// Write your Javascript code.
$(document).ready(function () {
  $('[data-toggle="offcanvas"]').click(function () {
    $('.row-offcanvas').toggleClass('active')
  });
});

//DataTable
$(document).ready(function () {
    $.fn.dataTable.moment( 'M/D/YYYY h:mm:s A' );

    $('#Stamps').DataTable();
} );