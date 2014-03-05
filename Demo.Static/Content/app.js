/// <reference path="hogan.min.js" />

// Load a hogan template and use it to add things to the page.
// See if images keep downloading
$(function () {
  var hoganTemplate = Hogan.compile($('#template').html());

  console.log('Using embedded resources');

  $('.more').on('click', function () {
    // Remove any images from the page
    $('img').each(function() {$(this).hide()})

    // Then re-render it
    var renderedHTML = hoganTemplate.render()
    $('#images').append(renderedHTML)
  })
})
