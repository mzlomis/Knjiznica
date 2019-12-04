﻿<%@ Master Language="C#" AutoEventWireup="true" CodeBehind="Site2.master.cs" Inherits="WebApplication2.Site2" %>

<!doctype html>
<!--[if lt IE 7 ]><html class="ie ie6" lang="en"> <![endif]-->
<!--[if IE 7 ]><html class="ie ie7" lang="en"> <![endif]-->
<!--[if IE 8 ]><html class="ie ie8" lang="en"> <![endif]-->
<!--[if (gte IE 9)|!(IE)]><!--><html lang="en"> <!--<![endif]-->
<head>
<meta charset="utf-8">

<!--
••••••••••••••••••••••••

Powered by Type & Grids™
www.typeandgrids.com

••••••••••••••••••••••••
-->

<title>Ivan Designostrom &mdash; Interactive Art Director</title>
<meta name="description" content="The portfolio of designer Ivan Designostrom">
<meta name="author" content="Ivan Designostrom">
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">

<!-- CSS
================================================================================================= -->
<link rel="stylesheet" href="css/base.css">
<link rel="stylesheet" href="css/themes/type_05.css">
<link rel="stylesheet" href="css/themes/color_06.css">

<!--[if lt IE 9]>
	<script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
<![endif]-->

<!-- Favicons
================================================================================================= -->
<link rel="shortcut icon" href="images/favicons/favicon.ico">
<link rel="apple-touch-icon" href="images/favicons/apple-touch-icon.png">
<link rel="apple-touch-icon" sizes="72x72" href="images/favicons/apple-touch-icon-72x72.png">
<link rel="apple-touch-icon" sizes="114x114" href="images/favicons/apple-touch-icon-114x114.png">

<!-- JS
================================================================================================= -->
<script src="js/libs/modernizr.min.js"></script>
<script src="js/libs/jquery-1.8.3.min.js"></script>
<script src="js/libs/jquery.easing.1.3.min.js"></script>
<script src="js/libs/jquery.fitvids.js"></script>
<script src="js/script.js"></script>

</head>
<body>

<!-- Write preloader to page - this allows the site to load for users with JS disabled -->
<script type="text/javascript">
	document.write("<div id='sitePreloader'><div id='preloaderImage'><img src='images/site_preloader.gif' alt='Preloader' /></div></div>");
</script>

<div class="container">
	
	<!-- Header begins ========================================================================== -->
	<header class="sixteen columns">
		<div id="logo">
			<h1>Ivan Designostrom</h1>
			<h2>Interactive Art Director</h2>
			<!--
			<img src="images/logo.png" width="275" height="35" alt="Logo" />
			-->
		</div>
		<nav>
			<ul>
				<li><button id="workPage">Work</button></li>
				<li><button id="aboutPage">About</button></li>
				<!--<li><a href="http://wordpress.org" target="_blank">Blog</a></li>-->
			</ul>
		</nav>
		<hr />
	</header>
	<!-- Header ends ============================================================================ -->
	
	<!-- Work page begins ======================================================================= -->
	<div id="work">
	
		<div id="overview" class="sixteen columns">
			<h3>Simple to set up and super-customizable, Type &amp; Grids is a responsive HTML5 template with nice typography.</h3>
			<hr />
		</div>
		
		<div class="eight columns" id="col1">
		
			<!-- Project begins ================================================================= -->
			<div class="project">
				
				<div class="projectThumbnail">
					<svg class="thumbnailMask"></svg>
					<div class="projectThumbnailHover">
						<h4>Project 01 Hover Title Goes Here</h4>
						<h5>Optional Hover Subtitle</h5>
					</div>
					
					<img src="images/projects/project_01_desaturated.jpg" alt="Project 01" class="thumbnailImage" />
				</div>
				
				<div class="projectInfo">
					<h4>Project 01 Title Goes Here</h4>
					<div class="projectNavCounter"></div>
					<div class="projectNav">
						<div class="projectNavEnlarge"><button class="enlargeButton" onClick="window.location.href='projects/project_01/index.html'">View full-size</button></div>
						<div class="projectNavClose"><button class="closeButton">Close</button></div>
						<div class="projectNavButtons"><button class="prev"></button><button class="next"></button></div>
					</div>
					<p>
						This is a description of the project. This text is optional and the site layout works fine without it. The slider above is swipe-enabled with hardware accelerated transitions so it works super smoothly on touch devices like the iPhone and iPad.
					</p>
					<ul>
						<li><strong>Client:</strong> Wernham Hogg</li>
						<li><strong>Role:</strong> Art Direction, Photography, Illustration</li>
						<li><strong>Year:</strong> 2013</li>
					</ul>
				</div>
				
			</div>
			<!-- Project ends =================================================================== -->
			
			<!-- Project begins ================================================================= -->
			<div class="project">
				
				<div class="projectThumbnail">
					<svg class="thumbnailMask"></svg>
					<div class="projectThumbnailHover">
						<h4>Project 02 Hover Title Goes Here</h4>
						<h5>Optional Hover Subtitle</h5>
					</div>
					<img src="images/projects/project_02_desaturated.jpg" alt="Project 02" class="thumbnailImage" />
				</div>
				
				<div class="projectInfo">
					<h4>Project 02 Title Goes Here</h4>
					<div class="projectNavCounter"></div>
					<div class="projectNav">
						<div class="projectNavEnlarge"><button class="enlargeButton" onClick="window.location.href='projects/project_02/index.html'">View video</button></div>
						<div class="projectNavClose"><button class="closeButton">Close</button></div>
						<div class="projectNavButtons"><button class="prev"></button><button class="next"></button></div>
					</div>
					
					<p>
						This is a description of the project. This text is optional and the site layout works fine without it. The slider above is swipe-enabled with hardware accelerated transitions so it works super smoothly on touch devices like the iPhone and iPad.
					</p>
					<ul>
						<li><strong>Client:</strong> Wernham Hogg</li>
						<li><strong>Role:</strong> Art Direction, Photography, Illustration</li>
						<li><strong>Year:</strong> 2013</li>
					</ul>
				</div>
				
			</div>
			<!-- Project ends =================================================================== -->
			
			<!-- Project begins ================================================================= -->
			<div class="project">
				
				<div class="projectThumbnail">
					<svg class="thumbnailMask"></svg>
					<div class="projectThumbnailHover">
						<h4>Project 03 Hover Title Goes Here</h4>
						<h5>Optional Hover Subtitle</h5>
					</div>
					<img src="images/projects/project_03_desaturated.jpg" alt="Project 03" class="thumbnailImage" />
				</div>
					
				<div class="projectInfo">
					<h4>Project 03 Title Goes Here</h4>
					<div class="projectNavCounter"></div>
					<div class="projectNav">
						<div class="projectNavEnlarge"><button class="enlargeButton">View full-size</button></div>
						<div class="projectNavClose"><button class="closeButton">Close</button></div>
						<div class="projectNavButtons"><button class="prev"></button><button class="next"></button></div>
					</div>
					<p>
						This is a description of the project. This text is optional and the site layout works fine without it. The slider above is swipe-enabled with hardware accelerated transitions so it works super smoothly on touch devices like the iPhone and iPad.
					</p>
					<ul>
						<li><strong>Client:</strong> Wernham Hogg</li>
						<li><strong>Role:</strong> Art Direction, Photography, Illustration</li>
						<li><strong>Year:</strong> 2013</li>
					</ul>
				</div>
				
			</div>
			<!-- Project ends =================================================================== -->
			
			<!-- Project begins ================================================================= -->
			<div class="project">
				
				<div class="projectThumbnail">
					<svg class="thumbnailMask"></svg>
					<div class="projectThumbnailHover">
						<h4>Project 04 Hover Title Goes Here</h4>
						<h5>Optional Hover Subtitle</h5>
					</div>
					<img src="images/projects/project_04_desaturated.jpg" alt="Project 04" class="thumbnailImage" />
				</div>
					
				<div class="projectInfo">
					<h4>Project 04 Title Goes Here</h4>
					<div class="projectNavCounter"></div>
					<div class="projectNav">
						<div class="projectNavEnlarge"><button class="enlargeButton" onClick="window.location.href='projects/project_01/index.html'">View full-size</button></div>
						<div class="projectNavClose"><button class="closeButton">Close</button></div>
						<div class="projectNavButtons"><button class="prev"></button><button class="next"></button></div>
					</div>
					<p>
						This is a description of the project. This text is optional and the site layout works fine without it. The slider above is swipe-enabled with hardware accelerated transitions so it works super smoothly on touch devices like the iPhone and iPad.
					</p>
					<ul>
						<li><strong>Client:</strong> Wernham Hogg</li>
						<li><strong>Role:</strong> Art Direction, Photography, Illustration</li>
						<li><strong>Year:</strong> 2013</li>
					</ul>
				</div>
				
			</div>
			<!-- Project ends =================================================================== -->
			
			<!-- Project begins ================================================================= -->
			<div class="project">
				
				<div class="projectThumbnail">
					<svg class="thumbnailMask"></svg>
					<div class="projectThumbnailHover">
						<h4>Project 05 Hover Title Goes Here</h4>
					</div>
					<img src="images/projects/project_05_desaturated.jpg" alt="Project 05" class="thumbnailImage" />
				</div>
				
				<div class="projectInfo">
					<h4>Project 05 Title Goes Here</h4>
					<div class="projectNavCounter"></div>
					<div class="projectNav">
						<div class="projectNavEnlarge"><button class="enlargeButton" onClick="window.location.href='projects/project_01/index.html'">View full-size</button></div>
						<div class="projectNavClose"><button class="closeButton">Close</button></div>
						<div class="projectNavButtons"><button class="prev"></button><button class="next"></button></div>
					</div>
					<p>
						This is a description of the project. This text is optional and the site layout works fine without it. The slider above is swipe-enabled with hardware accelerated transitions so it works super smoothly on touch devices like the iPhone and iPad.
					</p>
					<ul>
						<li><strong>Client:</strong> Wernham Hogg</li>
						<li><strong>Role:</strong> Art Direction, Photography, Illustration</li>
						<li><strong>Year:</strong> 2013</li>
					</ul>
				</div>
				
			</div>
			<!-- Project ends =================================================================== -->
			
			<!-- Project begins ================================================================= -->
			<div class="project">
				
				<div class="projectThumbnail">
					<svg class="thumbnailMask"></svg>
					<div class="projectThumbnailHover">
						<h4>Project 06 Hover Title Goes Here</h4>
						<h5>Optional Hover Subtitle</h5>
					</div>
					<img src="images/projects/project_06_desaturated.jpg" alt="Project 06" class="thumbnailImage" />
				</div>
					
				<div class="projectInfo">
					<h4>Project 06 Title Goes Here</h4>
					<div class="projectNavCounter"></div>
					<div class="projectNav">
						<div class="projectNavEnlarge"><button class="enlargeButton" onClick="window.location.href='projects/project_01/index.html'">View full-size</button></div>
						<div class="projectNavClose"><button class="closeButton">Close</button></div>
						<div class="projectNavButtons"><button class="prev"></button><button class="next"></button></div>
					</div>
					<p>
						This is a description of the project. This text is optional and the site layout works fine without it. The slider above is swipe-enabled with hardware accelerated transitions so it works super smoothly on touch devices like the iPhone and iPad.
					</p>
					<ul>
						<li><strong>Client:</strong> Wernham Hogg</li>
						<li><strong>Role:</strong> Art Direction, Photography, Illustration</li>
						<li><strong>Year:</strong> 2013</li>
					</ul>
				</div>
				
			</div>
			<!-- Project ends =================================================================== -->
			
		</div><!-- col1 -->
		
		<!-- Even numbered projects are dynamically moved into this second column via JS -->
		<div class="eight columns" id="col2">
		</div>
	
	</div>
	<!-- Work page ends ========================================================================= -->
	
	<!-- About page begins ====================================================================== -->
	<div id="about">
		
		<!-- Column 1 begins ==================================================================== -->
		<div class="eight columns">
			
			<h3>About page header</h3>
			<p>
			Type &amp; Grids is a HTML5 template that focuses on typography and grids. It's responsive which means it looks great on all devices from desktops to laptops to tablets and mobile phones. It's super-customizable and comes with lots of nicely designed type and color themes. Download the <a href="http://www.typeandgrids.com/downloads/type_and_grids_free.zip">free zip file</a> to get started!
			</p>
			
			<h4>Subheader lorem ipsum</h4>
			<p>
				10% of every sale is donated to the <strong><a href="http://www.audubon.org/" target="_blank">National Audubon Society</a></strong>. Audubon's mission: To conserve and restore natural ecosystems, focusing on birds, other wildlife, and their habitats for the benefit of humanity and the earth's biological diversity.
			</p>
			
			<h4>Subheader lorem ipsum</h4>
			<p>
				Type &amp; Grids comes with 19 different type theme CSS files and 28 different color theme CSS files. You can easily mix and match the type and color themes to create a unique design for your site. No CSS knowledge is needed and all of the fonts shown in the <a href="http://demo.typeandgrids.com" target="_blank">demo</a> are included. 58 different background textures come with the download as well.
			</p>
			
			<ul class="disc">
				<li>Simple to set up and update &ndash; all of the content is inside a single "index.html" page</li>
				<li>Contains 19 type themes and 28 color themes which gives you over 500 unique design combinations &ndash; 58 background textures are included as well</li>
				<li>Each type theme is meticulously handcrafted to ensure attention is paid to the small typographic details</li>
				<li>Fully responsive design &ndash; looks great on all devices from desktops to laptops to tablets and mobile phones</li>
				<li>Swipe-enabled with hardware accelerated transitions &ndash; works super smoothly on touch devices like the iPhone and iPad</li>
				<li>Coded using the latest HTML5/CSS3 standards and all code is <a href="http://validator.w3.org/check?uri=http%3A%2F%2Fdemo.typeandgrids.com%2F" target="_blank">W3C valid</a> and cross-browser compatible</li>
				<li>Video support &ndash; easily embed your videos from Vimeo or YouTube</li>
				<li>Clean and semantic SEO-friendly code</li>
				<li>Design featured on the <a href="http://www.thefwa.com/shortlist/jeremiah-shoaf" target="_blank">FWA Public Shortlist</a>, <a href="http://creattica.com/css/jeremiah-shoaf/90288" target="_blank">Creattica</a> and numerous other design sites</li>
				<li><a href="http://www.typeandgrids.com/support/" target="_blank">Support and documentation</a> is available but everything is so simple to set up you probably won't need it</li>
			</ul>
			
			<h4>Subheader lorem ipsum</h4>
			<p>
				Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ac ante arcu, quis auctor sapien. Morbi magna leo, dapibus a pulvinar et, pharetra scelerisque felis. Mauris massa magna, gravida vitae convallis sagittis, sagittis ac ipsum. Integer arcu justo, vehicula vel accumsan ac, venenatis in massa. Curabitur in dui in urna interdum ullamcorper. Pellentesque ut imperdiet libero.
			</p>
			
			<blockquote>
				&ldquo;Lorem ipsum dolor sit amet, <a href="http://www.google.com" target="_blank">consectetur adipiscing</a> elit. Donec ac ante arcu, quis auctor sapien. Morbi magna leo, dapibus a pulvinar et, pharetra scelerisque felis. Mauris massa magna, gravida vitae convallis sagittis, sagittis ac ipsum. Integer arcu justo, vehicula vel accumsan ac, venenatis in massa. Curabitur in dui in urna interdum ullamcorper. Pellentesque ut imperdiet libero.&rdquo;
				<cite>John Doe, <a href="http://www.google.com" target="_blank">Google</a></cite>
			</blockquote>
			
			<h4>Subheader lorem ipsum</h4>
			<p>
				Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ac ante arcu, quis auctor sapien. Morbi magna leo, dapibus a pulvinar et, pharetra scelerisque felis. Mauris massa magna, gravida vitae convallis sagittis, sagittis ac ipsum. Integer arcu justo, vehicula vel accumsan ac, venenatis in massa. Curabitur in dui in urna interdum ullamcorper. Pellentesque ut imperdiet libero.
			</p>
			
			<h4>Subheader lorem ipsum</h4>
			<p>
				Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ac ante arcu, quis auctor sapien. Morbi magna leo, dapibus a pulvinar et, pharetra scelerisque felis. Mauris massa magna, gravida vitae convallis sagittis, sagittis ac ipsum. Integer arcu justo, vehicula vel accumsan ac, venenatis in massa. Curabitur in dui in urna interdum ullamcorper. Pellentesque ut imperdiet libero.
			</p>
			
		</div>
		<!-- Column 1 ends ====================================================================== -->
		
		<!-- Column 2 begins ==================================================================== -->
		<div class="eight columns">
			
			<img src="images/about.jpg" alt="About" />
			
			<ul class="linedList">
				<li><strong>Location:</strong> Stockholm, Sweden</li>
				<li><strong>Email:</strong> <a href="mailto:hello@ivandesignostrom.com">hello@ivandesignostrom.com</a></li>
				<li><strong>R&eacute;sum&eacute;:</strong> <a href="resume.pdf">resume.pdf</a></li>
				<li><strong>LinkedIn:</strong> <a href="http://www.linkedin.com/" target="_blank">www.linkedin.com/in/ivandesignostrom</a></li>
			</ul>
			
		</div>
		<!-- Column 2 ends ====================================================================== -->
		
	</div>
	<!-- About page ends ======================================================================== -->
	
	<!-- Footer begins ========================================================================== -->
	<footer class="sixteen columns">
		<hr />
		<ul id="footerLinks">
			<li>&copy; 2013 Ivan Designostrom. All rights reserved.</li>
			<li><a href="mailto:hello@ivandesignostrom.com">hello@ivandesignostrom.com</a></li>
			<li><a href="http://www.twitter.com" target="_blank">Twitter</a></li>
			<!--Notice: The "Powered by Type & Grids" link in the footer is required in the Free version. Upgrade to the Pro version if you would like to remove it.-->
			<li><a href="http://www.typeandgrids.com" target="_blank">Powered by Type &amp; Grids</a></li>
		</ul>
	</footer>
	<!-- Footer ends ============================================================================ -->
		
</div><!-- container -->
</body>
</html>
