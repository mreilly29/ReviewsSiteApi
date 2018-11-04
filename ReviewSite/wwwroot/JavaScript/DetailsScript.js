document.addEventListener("DOMContentLoaded", (event) => {    
    refreshComments();
    const saveComment = document.querySelector('#save-comment');
    saveComment.addEventListener('click', createComment);
    
});

function createComment() {
    const commentInput = document.querySelector('#new-comment');
    const newCommentText = document.querySelector('#new-comment').value;
    const newComment = {
        text: newCommentText,
        reviewId: reviewId
    };

    fetch('/Api/Comments', {
        method: 'POST',
        body: JSON.stringify(newComment), 
        headers: {
            'Content-Type': 'application/json',
            'Accept': 'application/json'
        }
    }).then(() => {
        commentInput.value = '';
        refreshComments();
    });
}



function refreshComments() {
    const ol = document.querySelector('#comment-list');
    ol.innerHTML = '';
    fetch(`/api/comments/${reviewId}`)
        .then(res => res.json())
        .then(data => {
            console.log(data);
            data.forEach(c => addCommentToDom(c));
        });
}



function addCommentToDom(comment) {
    const li = document.createElement('li');
    const date = new Date(comment.createdAt);

    li.innerHTML = `${comment.text} <div>${date.toDateString()}</div>`;
    const ol = document.querySelector('#comment-list');
    ol.appendChild(li);
}
