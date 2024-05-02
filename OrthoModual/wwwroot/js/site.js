// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//function selectMenuItem(element) {
//    debugger
//    // Remove 'active' class from previously selected item
//    var previouslySelectedItem = $('.nav-item.nav-list.active');;
//    if (previouslySelectedItem.length > 0) {
//        previouslySelectedItem.removeClass('active');
//    }
//    
//    // Add 'active' class to the clicked item
//    $(element).addClass('active');
//}

$(document).ready(function() {
    // Add click event listener to the anchor tag
    $('.sidebar-toggle').on('click', function(event) {
        event.preventDefault(); // Prevent default anchor behavior

        // Toggle the 'sidebar-collapse' class on the body
        $('body').toggleClass('sidebar-collapse');
    });

    $('.sidebar-menu li').on('click', function(event) {
        // debugger
        // Remove the 'active' class from all sidebar menu items
        $('.sidebar-menu li').removeClass('active');
        
        // Add the 'active' class to the clicked sidebar menu item
        $(this).addClass('active');
    });

     new $('#example1').DataTable();

     setTimeout(function () {
        var successMessage = document.getElementById('Message');
        if (successMessage) {
            successMessage.style.display = 'none';
        }
    }, 5000);
    
});


function toggleTreeViewMenu(event) {
    event.preventDefault(); // Prevent default behavior of anchor tag
    var $submenu = $(event.target).siblings('.treeview-menu');
    $submenu.toggle(); // Toggle the display of the submenu

    // Toggle the direction of the arrow icon
    var $arrowIcon = $(event.target).find('.fa-angle-left');

    if ($arrowIcon.hasClass('fa-angle-left')) {
        $arrowIcon.toggleClass('fa-angle-left fa-angle-down');
    } else { 
        $arrowIcon = $(event.target).find('.fa-angle-down');
        $arrowIcon.toggleClass('fa-angle-down fa-angle-left');
    }
}
