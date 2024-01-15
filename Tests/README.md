<style>
    /* customizable snowflake styling */
    .snowflake {
        color: #fff;
        font-size: 1em;
        font-family: Arial;
        text-shadow: 0 0 1px #000;
    }

    @-webkit-keyframes snowflakes-fall {
        0% {
            top: -10%
        }

        100% {
            top: 100%
        }
    }

    @-webkit-keyframes snowflakes-shake {
        0% {
            -webkit-transform: translateX(0px);
            transform: translateX(0px)
        }

        50% {
            -webkit-transform: translateX(80px);
            transform: translateX(80px)
        }

        100% {
            -webkit-transform: translateX(0px);
            transform: translateX(0px)
        }
    }

    @keyframes snowflakes-fall {
        0% {
            top: -10%
        }

        100% {
            top: 100%
        }
    }

    @keyframes snowflakes-shake {
        0% {
            transform: translateX(0px)
        }

        50% {
            transform: translateX(80px)
        }

        100% {
            transform: translateX(0px)
        }
    }

    .snowflake {
        position: fixed;
        top: -10%;
        z-index: 9999;
        -webkit-user-select: none;
        -moz-user-select: none;
        -ms-user-select: none;
        user-select: none;
        cursor: default;
        -webkit-animation-name: snowflakes-fall, snowflakes-shake;
        -webkit-animation-duration: 10s, 3s;
        -webkit-animation-timing-function: linear, ease-in-out;
        -webkit-animation-iteration-count: infinite, infinite;
        -webkit-animation-play-state: running, running;
        animation-name: snowflakes-fall, snowflakes-shake;
        animation-duration: 10s, 3s;
        animation-timing-function: linear, ease-in-out;
        animation-iteration-count: infinite, infinite;
        animation-play-state: running, running
    }

    .snowflake:nth-of-type(0) {
        left: 1%;
        -webkit-animation-delay: 0s, 0s;
        animation-delay: 0s, 0s
    }

    .snowflake:nth-of-type(1) {
        left: 10%;
        -webkit-animation-delay: 1s, 1s;
        animation-delay: 1s, 1s
    }

    .snowflake:nth-of-type(2) {
        left: 20%;
        -webkit-animation-delay: 6s, .5s;
        animation-delay: 6s, .5s
    }

    .snowflake:nth-of-type(3) {
        left: 30%;
        -webkit-animation-delay: 4s, 2s;
        animation-delay: 4s, 2s
    }

    .snowflake:nth-of-type(4) {
        left: 40%;
        -webkit-animation-delay: 2s, 2s;
        animation-delay: 2s, 2s
    }

    .snowflake:nth-of-type(5) {
        left: 50%;
        -webkit-animation-delay: 8s, 3s;
        animation-delay: 8s, 3s
    }

    .snowflake:nth-of-type(6) {
        left: 60%;
        -webkit-animation-delay: 6s, 2s;
        animation-delay: 6s, 2s
    }

    .snowflake:nth-of-type(7) {
        left: 70%;
        -webkit-animation-delay: 2.5s, 1s;
        animation-delay: 2.5s, 1s
    }

    .snowflake:nth-of-type(8) {
        left: 80%;
        -webkit-animation-delay: 1s, 0s;
        animation-delay: 1s, 0s
    }

    .snowflake:nth-of-type(9) {
        left: 90%;
        -webkit-animation-delay: 3s, 1.5s;
        animation-delay: 3s, 1.5s
    }

    /* Demo Purpose Only*/
    .demo {
        font-family: 'Raleway', sans-serif;
        color: #fff;
        display: block;
        margin: 0 auto;
        padding: 15px 0;
        text-align: center;
    }

    .demo a {
        font-family: 'Raleway', sans-serif;
        color: #000;
    }

    #banner {
        font-size: clamp(2.8rem, 1.5vw, 3rem);
        font-weight: bold;
        margin: 5px;
        background: linear-gradient(to right,
                #7953cd 20%,
                #00affa 30%,
                #0190cd 70%,
                #764ada 80%);
        -webkit-background-clip: text;
        background-clip: text;
        -webkit-text-fill-color: transparent;
        text-fill-color: transparent;
        background-size: 500% auto;
        animation: textShine 5s ease-in-out infinite alternate;
    }
    @keyframes textShine {
        0% {
            background-position: 0% 50%;
        }

        100% {
            background-position: 100% 50%;
        }
    }
</style>

<!-- Main Header -->
<span id="banner">Temporary Functionality Test of Wiki</span>

## Overview

Original Draft: 2023-01-15  
Publication: N/A  

This is a development-time test and shall be hidden from the view of the general public. This file tests the functionalities of the wiki. It's an adaption of https://www.totalimagine.com/Resources/CoolMarkdown.html, and tests various aspects of the wiki functions.

## Tests

### Basic Formatting

1. Text formatting: **bold**, *italic*, ***bold italic***, and ~~strikethrough~~.
5. LaTeX formulas: $E=mc^2$.

<!-- Table -->

|Markdown|Word Doc|Text|
|-|-|-|
|Light weight|Binary|Light Weight|
|Plain Text + HTML, CSS, SVG|XML and Indecipherable|Plain Text|

<!-- Chart -->

```mermaid
mindmap
  root((mindmap))
    Origins
      Long history
      ::icon(fa fa-book)
      Popularisation
        British popular psychology author Tony Buzan
    Research
      On effectiveness<br/>and features
      On Automatic creation
        Uses
            Creative techniques
            Strategic planning
            Argument mapping
    Tools
      Pen and paper
      Mermaid
```

<script>NekoType="white"</script>
<h1 id=nl><script src="https://webneko.net/n20171213.js"></script><a 
href="https://webneko.net">Neko</a></h1>