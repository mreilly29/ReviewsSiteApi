document.addEventListener("DOMContentLoaded", (event) => {
    refreshTags();
    const saveTag = document.querySelector('#save-tag');
    saveTag.addEventListener('click', createTag);
});

function createTag() {
    const tagInput = document.querySelector('#new-tag');
    const newTagText = document.querySelector('#new-tag').value;
    console.log('the reviewId is: ', reviewId);
    const newTag = {
        name: newTagText
    };

    fetch(`/api/tags?reviewId=${reviewId}`, {
        method: 'POST',
        body: JSON.stringify(newTag),
        headers: {
            'Content-Type': 'application/json'
        }
        
    }).then(() => {
        tagInput.value = '';
        refreshTags();
    });
}
    
    function refreshTags() {
        const ul = document.querySelector('#tag-list');
        ul.innerHTML = '';
        fetch(`/Api/Tags/${reviewId}`)
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
        const a = document.createElement('a');
        a.href = `/tags/details/${tag.id}`
        a.innerHTML = tag.name;
        li.appendChild(a);
        
        ul.appendChild(li);
    }