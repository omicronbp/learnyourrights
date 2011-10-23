/*
  JACG: Just Another Corners&Gradients.
  Requires jQuery (tested on 1.4.1, but no new features used).
  Optionally uses base64 ( http://plugins.jquery.com/project/base64 ).

  Copyright 2010 MyFreeWeb
  
  Licensed under the Apache License, Version 2.0 (the "License");
  you may not use this file except in compliance with the License.
  You may obtain a copy of the License at
  
  http://www.apache.org/licenses/LICENSE-2.0
  
  Unless required by applicable law or agreed to in writing, software
  distributed under the License is distributed on an "AS IS" BASIS,
  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
  See the License for the specific language governing permissions and
  limitations under the License.
*/
function svgradient(start, end, round) {
  if (round != undefined) {
    round.replace('px', '');
    var r = 'rx="' + round + '" ry="' + round + '"';
  }
  else { var r = ''; }
  var svg = '<?xml version="1.0" ?><svg xmlns="http://www.w3.org/2000/svg"><defs><linearGradient id="gr" x1="0%" y1="0%" x2="0%" y2="100%"><stop offset="0%" style="stop-color:' +  start + '"/><stop offset="100%" style="stop-color:' + end + '"/></linearGradient></defs><rect x="0" y="0" ' + r + ' width="100%" height="100%" style="fill:url(#gr)"/></svg>';
  if ($.base64Encode) {
    return 'data:image/svg+xml;base64,' + $.base64Encode(svg);
  }
  else {
    return 'data:image/svg+xml,' + escape(svg);
  }
}
function webgr(obj, start, end, height, padding) {
  he = parseInt(height.replace('px', '')) + parseInt(padding.replace('px', ''))*2; // This is strange, really. But I have to.
  return obj.css({'background':
      'url("http://webgradients.appspot.com/make?width=1&height=' + he + '&start=' + start.replace('#', '') +'&end=' + end.replace('#', '') + '") repeat-x'});
}
(function($){  
  $.fn.extend({
    jacg: function(options) {
	var defaults = {
	radius: '15px',
	start: '#dddddd',
	end: '#cccccc',
	}
	var o = $.extend(defaults, options);
	return this.each(function() {
	    obj = $(this).css({'border-radius': o.radius}); // I can haz chains!

	    if ($.browser.webkit == true) { // WebKit: Safari, Chrome, Midori, etc.
	      obj.css({'-webkit-border-radius': o.radius,
		    'background': '-webkit-gradient(linear, left top, left bottom, from(' + o.start + '), to(' + o.end + '))'});
	    }
	    else if ($.browser.mozilla == true) { // Gecko: Firefox, Flock, Conkeror, etc.
	      obj.css({'-moz-border-radius': o.radius,
		    'background': '-moz-linear-gradient(top, ' + o.start + ', ' + o.end + ')'});
	      if (parseInt($.browser.version.replace('.', '').replace('.', '')) < 192) { // Gecko 1.9.2 is in Fx 3.6
		// Firefox <= 3.5 has no support for CSS gradients
		// So we use Web Gradients (that's my app too!)
		webgr(obj, o.start, o.end, obj.css('height'), obj.css('padding-bottom'));
	      }
	    }
	    else if ($.browser.opera == true) { // Presto: Opera
	      if (opera.version() >= 10.50) {
		obj.css({'background': 'url("' + svgradient(o.start, o.end) + '")'});
		// The corners are specified at top of the fuction
	      }
	      else {
		obj.css({'background': 'url("' + svgradient(o.start, o.end, o.radius) + '")'});
	      }
	    }
	    else { // Any other browser
	      webgr(obj, o.start, o.end, obj.css('height'), obj.css('padding-bottom'));
	    }
	  });
      }
    });
 })(jQuery);
