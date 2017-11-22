// Write your Javascript code.
$(document).ready(function () {
    $('[data-toggle="offcanvas"]').click(function () {
        $('.row-offcanvas').toggleClass('active')
    });
});



function getStamps() {
    var stamps = [];
    $("#Stamps tbody tr").each(function (i, v) {
        stamps[i] = $(this).find(".stampLocation").text();
    });

    return stamps;
}

$(function () {
    var map = {
        '4500': { 'x': 400, 'y': 100 },
        '36288': { 'x': 380, 'y': 250 },
        '36646': { 'x': 440, 'y': 480 },
        '3505': { 'x': 520, 'y': 200 },
        '19053': { 'x': 520, 'y': 600 },
        '19350': { 'x': 650, 'y': 400 }
    }
    var svg = d3.select("#svg").append("svg")
        .attr("width", 700)
        .attr("height", 700);

    var imgs = svg.selectAll("image").data([0]);
    imgs.enter()
        .append("svg:image")
        .attr("xlink:href", "/images/MopacC4Block.png")
        .attr("id", "floorPlan")
        .attr("style", "display:block; width: 100%; height: 100%; margin: auto;");
    var d3line = d3.svg.line()
        .x(function (d) { return d.x; })
        .y(function (d) { return d.y; })
        .interpolate("monotone");

    var stamps = getStamps();

    var data = [];
    //plot the data
    for (var i = 0; i < stamps.length; i++) {
        data[i] = map[stamps[i]];
    }

    svg.append("path").attr("d", d3line(data))
        .style("stroke-width", 2.5)
        .style("stroke", "#ff0000")
        .style("fill", "none")
        .style('stroke-opacity', 0.85);
})

//DataTable
$(document).ready(function () {
    $.fn.dataTable.moment('M/D/YYYY h:mm:s A');
    $('#Stamps').DataTable({
        "order": [[2,"desc"]]
    });
});