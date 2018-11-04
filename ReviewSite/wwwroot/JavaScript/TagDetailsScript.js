(function () {

    setUpPage();

    function setUpPage() {

        DisplayTagName();
        
    }


    function DisplayTagName() {
        const h1 = document.querySelector('#tag-name');        
        h1.innerHTML = `${ tagName }`;
    }
    
    


})();