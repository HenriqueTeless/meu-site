function toggleInfo(professorId) {
    var info = document.getElementById(professorId);
    if (info.style.display === "block") {
      info.style.display = "none";
    } else {
      var allInfos = document.querySelectorAll('.professor-info');
      allInfos.forEach(function(item) {
        item.style.display = "none";
      });
      info.style.display = "block";
    }
  }
  