function getContent(thisUrl) {
    $('#content').load(thisUrl);
}

function getSidebar(thisUrl) {
    $('#sidebar').load(thisUrl);
}

function getFavoriteShows() {
    $('#favoriteShows').load("/Home/GetFavoriteShows/");
}

function getFavoriteEpisodes(id) {
    $('#favoriteEpisodes').load("/Home/GetFavoriteEpisodes/" + id);
}

function getRecentShows() {
    $('#recentShows').load("/Home/GetRecentShows/");
}