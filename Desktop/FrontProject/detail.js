const box = document.getElementById("detail");

const params = new URLSearchParams(window.location.search);
const id = params.get("id");

axios.get(`https://api.tvmaze.com/shows/${id}`)
  .then(res => {
    const s = res.data;

    box.innerHTML = `
      <h2>${s.name}</h2>
      <img src="${s.image?.original || s.image?.medium || ''}">
      <p><strong>Language:</strong> ${s.language}</p>
      <p><strong>Genres:</strong> ${s.genres.join(", ")}</p>
      <p><strong>Status:</strong> ${s.status}</p>
      <p><strong>Rating:</strong> ${s.rating.average || "N/A"}</p>
      <p>${s.summary || ""}</p>
    `;
  });
