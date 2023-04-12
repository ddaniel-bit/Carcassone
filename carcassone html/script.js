var images = ["img/fomenuscreen.png", "img/jatekkezdesscreen.png", "img/palyavalasztas.png","img/beallitasok.png", "img/nemtudszlerakni.png", "img/Pontozas.png", "img/toplista.png" ]; //,"img/tren.png"
var currentIndex = 0;

function changeImage(n) {
  currentIndex += n;
  if (currentIndex < 0) {
    currentIndex = images.length - 1;
  } else if (currentIndex >= images.length) {
    currentIndex = 0;
  }
  document.getElementById("mainImage").src = images[currentIndex];
}
