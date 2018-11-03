(function () {

    setUpPage();

    function setUpPage() {
        headerCarousel();
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
        let { imageUrl } = slides[sliderIndex];
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

}) ();