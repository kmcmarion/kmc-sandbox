$(document).ready(function () {
    //CareerSearch();
    CareersPaginate();

    function CareerSearch() {
        var input, filter, table, tr, td, i;

        input = document.getElementById("careerInput");
        if (input === null) return;

        filter = input.value.toUpperCase();
        table = document.getElementById('careers_tb_all');
        tr = table.getElementsByTagName('tr');
        for (i = 0; i < tr.length; i++) {
            td = tr[i].getElementsByTagName("td")[0];
            if (td) {
                if (td.innerHTML.toUpperCase().indexOf(filter) > -1) {
                    tr[i].style.display = "";
                } else {
                    tr[i].style.display = "none";
                }
            }
        }
    }

    function CareersPaginate() {

        var numberOfItems = $('#careers_tb_all tr').length;
        var limitPerPage = 10;

        $("#careers_tb_all tr:gt(" + (limitPerPage - 1) + ")").hide();
        var totalPages = Math.round(numberOfItems / limitPerPage);

        $('.pagination').append("<li class='page-item current-page active'><a class='page-link' href='javascript:void(0)'>" + 1 + "</a></li>");

        for (var i = 2; i <= totalPages; i++) {
            $(".pagination").append("<li class='page-item current-page'><a class='page-link' href='javascript:void(0)'>" + i + "</a></li>")
        }

        $('.pagination').append("<li id='next-page' class='page-item'><a class='page-link' href='javascript:void(0)' aria-label='Next'><span aria-hidden='true'>&raquo;</span><span class='sr-only'>Next</span></a></li>");

        $(".pagination li.current-page").on("click", function () {

            if ($(this).hasClass("active")) {
                return false;
            }

            else {
                var currentPage = $(this).index();
                //add active class to clicked number
                $(".pagination li").removeClass("active");
                $(this).addClass('active');

                $("#careers_tb_all tr").hide();

                //show items for selected page num
                var grandTotal = limitPerPage * currentPage;
                for (var i = grandTotal - limitPerPage; i < grandTotal; i++) {
                    $("#careers_tb_all tr:eq(" + i + ")").show();
                }
            }
        });

        $('#next-page').on("click", function () {
            var currentPage = $(".pagination li.active").index();
            if (currentPage === totalPages) {
                return false;
            }
            else {
                currentPage++;
                $(".pagination li").removeClass("active");
                $("#careers_tb_all tr").hide();

                var grandTotal = limitPerPage * currentPage;
                for (var i = grandTotal - limitPerPage; i < grandTotal; i++) {
                    $("#careers_tb_all tr:eq(" + i + ")").show();
                }
                $(".pagination li.current-page:eq(" + (currentPage - 1) + ")").addClass("active");
            }
        });

        $('#previous-page').on("click", function () {
            var currentPage = $(".pagination li.active").index();
            if (currentPage === 1) {
                return false;
            }
            else {
                currentPage--;
                $(".pagination li").removeClass("active");
                $("#careers_tb_all tr").hide();

                var grandTotal = limitPerPage * currentPage;
                for (var i = grandTotal - limitPerPage; i < grandTotal; i++) {
                    $("#careers_tb_all tr:eq(" + i + ")").show();
                }
                $(".pagination li.current-page:eq(" + (currentPage - 1) + ")").addClass("active");
            }
        });
    }
})

