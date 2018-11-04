document.addEventListener("DOMContentLoaded", (event) => {
    refreshTags();
    const saveTag = document.querySelector('#save-tag');
    saveTag.addEventListener('click', createTag);
    console.log(reviewId);
});

function createTag() {
    const tagInput = document.querySelector('#new-tag');
    const newTagText = document.querySelector('#new-tag').value;
    const newTag = {
        text: newTagText,
        reviewId: reviewId
    };

    fetch('/Api/Tags', {
        method: 'POST',
        body: JSON.stringify(newTag),
        headers: {
            'Content-Type': 'application/json',
            'Accept': 'application/json'
        }
    }).then(() => {
        tagInput.value = '';
        refreshTags();
    });
}
    
    function refreshTags() {
        const ul = document.querySelector('#tag-list');
        ul.innerHTML = '';
        let id = reviewId
        fetch(`/Api/Tags/${id}`)
            .then(res => res.json())
                .then(data => {
                    console.log(data);
                    data.forEach(c => addTagToDom(c));
                });
    }

    function addTagToDom(tag) {
        const li = document.createElement('li');
        console.log(tag);
        const ul = document.querySelector('#tag-list');
        
        li.innerHTML = tag.name;
        ul.appendChild(li);
    }