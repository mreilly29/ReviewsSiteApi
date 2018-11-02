(function () {

    setUpPage();

    function setUpPage() {

        NavMenuToggle();
        resetOpenCloseWindows();
        headerCarousel();
    }

    // Navigation menu can be toggled
    function NavMenuToggle() {

        const nav = document.querySelector('nav');

        const navClickHandler = function () {
            this.classList.toggle('open');
            event.stopPropagation();
        };

        nav.addEventListener('click', navClickHandler);

        const bodyClickHandler = function () {
            nav.classList.remove('open');
        };

        document.body.addEventListener('click', bodyClickHandler);
    }

    // Resizing the window resets open/closed product details
    // Resizing the window resets nav visibility
    function resetOpenCloseWindows() {

        const windowResizeHandler = function () {

            const nav = document.querySelector('nav');
            nav.classList.remove('open');

            const articles = document.querySelectorAll('#products article');

            for (let article of articles) {
                article.classList.remove('expanded');
            }
        };

        window.addEventListener('resize', windowResizeHandler);
    }


    // Image Carousel / Slider
    function headerCarousel() {
        
        const sliderFrame = document.getElementById('slider-frame');

        const slides =
            Array.from(sliderFrame.querySelectorAll('div[data-src]'))
                .map(div => {
                    return {
                        imageUrl: div.getAttribute('data-src'),
                        caption: div.textContent.trim(),
                    };
                });

        let sliderIndex = 0;
        displaySliderImage();

        function displaySliderImage() {
            let {imageUrl} = slides[sliderIndex];
            sliderFrame.style.backgroundImage = `url('${imageUrl}')`;           
        }
        function displayNextSliderImage() {
            sliderIndex++;
            if (sliderIndex === slides.length) {
                sliderIndex = 0;
            }
            displaySliderImage();
        }
        setInterval(function () {
            displayNextSliderImage();
        }, 2000);
    }


})();