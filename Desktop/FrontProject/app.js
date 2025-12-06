let page = 0;
const list = document.getElementById("list");
const searchInput = document.getElementById("search");

function loadShows() {
  fetch(`https://api.tvmaze.com/shows?page=${page}`)
    .then(res => res.json())
    .then(data => render(data));
}

function render(data) {
  data.forEach(show => {
    const card = document.createElement("div");
    card.className = "card";
    card.innerHTML = `
      <img src="${show.image?.medium || ''}">
      <p>${show.name}</p>
    `;
    card.onclick = () => window.location = `detail.html?id=${show.id}`;
    list.appendChild(card);
  });
}

document.getElementById("loadMore").onclick = () => {
  page++;
  loadShows();
};

searchInput.oninput = () => {
  const q = searchInput.value.trim();
  list.innerHTML = "";

  if (!q) return loadShows();

  fetch(`https://api.tvmaze.com/search/shows?q=${q}`)
    .then(res => res.json())
    .then(data => render(data.map(x => x.show)));
};

loadShows();
