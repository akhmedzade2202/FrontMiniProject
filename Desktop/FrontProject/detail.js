const box = document.getElementById("detail");

const params = new URLSearchParams(window.location.search);
const id = params.get("id");

axios.get(`https://api.tvmaze.com/shows/${id}`)
  .then(res => {
    const showData = res.data; 

    box.innerHTML = `
      <h2>${showData.name}</h2>
      <img src="${showData.image?.original || showData.image?.medium || ''}">
      <p><strong>Language:</strong> ${showData.language}</p>
      <p><strong>Genres:</strong> ${showData.genres.join(", ")}</p>
      <p><strong>Status:</strong> ${showData.status}</p>
      <p><strong>Rating:</strong> ${showData.rating.average || "N/A"}</p>
      <p>${showData.summary || "No description available"}</p>
    `;
  });
