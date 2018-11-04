(function () {

    setUpPage();

    function setUpPage() {

        DisplayTags();
        
    }


    function DisplayTags() {
        const h1 = document.querySelector('#tag-name');

        fetch(`/api/tags/${tagId}`)
            .then(res => res.json())
            .then(data => {
                console.log(data);
                data.Name;
            });
        h1.innerHTML = data.Name;
    }






})();