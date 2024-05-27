window.addEventListener('scroll', function() {
    var container = document.querySelector('.container1');
    var containerOffset = container.getBoundingClientRect().top;

    if (containerOffset <= 0) {
        container.classList.add('sticky');
    } else {
        container.classList.remove('sticky');
    }
});
