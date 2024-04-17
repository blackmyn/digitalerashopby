/* ---------------------------------- partner config ---------------------------------- */

let partnerId = "woo_primeabgb";
let shopify_store_domain = typeof Shopify !== 'undefined' && Shopify.shop ? Shopify.shop : "https://www.primeabgb.com/";
let shopify_brand_name = "";
let shopify_brand_colour = "";
let high_light_colour = "";

const dark_bg_color = "#0173ba";

/* ---------------------------------- partner config ---------------------------------- */

const rgba_backgroud = "rgba(49, 49, 49, 0.10)";
const adjust_svg = true;

let info_image =
  "https://d30flbpbaljuso.cloudfront.net/shopify-messaging-app/info_default.png";

const icon1 = `<svg style="stroke: NONE;" xmlns="http://www.w3.org/2000/svg" width="26" height="26" viewBox="0 0 26 26" fill="none"> <path style="fill:none" d="M13 25C19.6274 25 25 19.6274 25 13C25 6.37258 19.6274 1 13 1C6.37258 1 1 6.37258 1 13C1 19.6274 6.37258 25 13 25Z" stroke="${dark_bg_color}" stroke-miterlimit="10"/> <path d="M11.2862 14.4959C12.2919 13.4761 13.2218 12.5351 14.1532 11.5925C14.2431 11.5027 14.3249 11.358 14.4285 11.3383C14.6421 11.3145 14.8576 11.3111 15.0719 11.3282C15.0704 11.5417 15.1477 11.8031 15.0521 11.9575C14.885 12.2286 14.6125 12.4364 14.3807 12.6668C13.507 13.5406 12.6249 14.4072 11.7596 15.2893C11.4323 15.6223 11.1584 15.6166 10.8368 15.2865C10.216 14.6488 9.58243 14.0223 8.94615 13.4001C8.45588 12.9212 7.91651 12.886 7.49799 13.2835C7.0736 13.6853 7.08926 14.2948 7.5668 14.7795C8.54868 15.7754 9.53891 16.7634 10.5375 17.7433C11.0488 18.2448 11.5615 18.2433 12.0658 17.7404C14.4228 15.3933 16.7756 13.0419 19.1242 10.6863C19.5822 10.2269 19.6019 9.63419 19.2042 9.23243C18.7955 8.82088 18.2407 8.84474 17.7561 9.30126C17.558 9.48809 17.3965 9.74098 17.1648 9.8589C16.9653 9.95863 16.6899 9.90812 16.4498 9.92489C16.4695 9.69734 16.4105 9.41774 16.5243 9.25486C16.7542 8.95016 17.0235 8.67718 17.3249 8.44298C18.0727 7.82075 19.2282 7.90927 19.8996 8.6186C20.2397 8.96989 20.4278 9.44091 20.4234 9.92983C20.4189 10.4187 20.2222 10.8863 19.8758 11.2313C18.9684 12.1738 18.0287 13.0854 17.1045 14.0111C15.6914 15.4257 14.2778 16.8398 12.8638 18.2533C11.813 19.3025 10.799 19.3041 9.73703 18.2518C8.79449 17.3178 7.85662 16.379 6.92345 15.4355C6.08205 14.5844 6.03992 13.4367 6.81109 12.6614C7.59489 11.8719 8.76124 11.9098 9.62183 12.7695C10.1583 13.3076 10.678 13.8652 11.2862 14.4959Z" fill="${dark_bg_color}"/> <path d="M15.5508 11.4859C15.3444 11.1446 15.1083 10.8833 15.1561 10.8102C15.3247 10.5546 15.5929 10.3635 15.823 10.1472C15.9663 10.3045 16.2598 10.532 16.2248 10.6051C16.0943 10.8805 15.857 11.1066 15.5508 11.4859Z" fill="${dark_bg_color}"/> </svg>`;
const icon2 = `<svg style="stroke: NONE;" width="24" height="25" viewBox="0 0 24 25" fill="none" xmlns="http://www.w3.org/2000/svg"> <path d="M3.76784 5.80577C3.55196 5.59226 3.33136 5.3838 3.12021 5.16439C3.02159 5.06582 2.95615 4.93897 2.93301 4.80148C2.90987 4.66398 2.93017 4.5227 2.99109 4.39728C3.04719 4.26927 3.14226 4.16225 3.26277 4.09145C3.38327 4.02065 3.52306 3.9897 3.66218 4.00302C3.8034 4.035 3.93875 4.08878 4.06337 4.16249C4.10559 4.19056 4.14289 4.22541 4.17376 4.26563C9.6665 9.75836 15.1607 15.2519 20.6565 20.7462C20.7548 20.8274 20.8301 20.933 20.875 21.0523C20.9198 21.1717 20.9327 21.3007 20.9122 21.4266C20.8929 21.5511 20.8385 21.6675 20.7554 21.7623C20.6723 21.857 20.564 21.9262 20.443 21.9616C20.3221 22.0049 20.1912 22.0117 20.0665 21.9813C19.9417 21.9508 19.8287 21.8844 19.7414 21.7903C19.244 21.2976 18.7442 20.8026 18.2561 20.3004C18.2065 20.2459 18.1455 20.2031 18.0773 20.1751C18.0091 20.1471 17.9356 20.1346 17.862 20.1386C13.0098 20.1433 8.1569 20.1449 3.30317 20.1433C3.01682 20.1619 2.73322 20.0778 2.50321 19.9063C2.27319 19.7347 2.11179 19.4868 2.04794 19.2071C2.01776 19.0676 2.00513 18.9249 2.01031 18.7823C2.00795 16.0229 2.00716 13.2636 2.00794 10.5045C2.00794 9.39231 2.00636 8.28095 2.00321 7.17036C1.985 6.92001 2.0447 6.67015 2.17409 6.45506C2.30348 6.23997 2.49625 6.0702 2.72595 5.96899C2.92425 5.89755 3.13239 5.85719 3.34302 5.84932C3.47973 5.84028 3.61686 5.83946 3.75366 5.84693C3.75736 5.83287 3.7621 5.81912 3.76784 5.80577ZM16.6678 18.7527L16.7031 18.7105C16.6532 18.6793 16.6053 18.6448 16.56 18.6072C14.0635 16.1131 11.5685 13.6166 9.07518 11.1178C9.01472 11.0495 8.93966 10.9957 8.85557 10.9604C8.77148 10.9251 8.68053 10.9092 8.58944 10.9138C6.91411 10.9256 5.23893 10.9207 3.56597 10.9207H3.40411V18.7551C7.82924 18.7527 12.2505 18.7519 16.6678 18.7527ZM7.47734 9.52709L5.20603 7.25578C5.18077 7.23133 5.14732 7.21712 5.11218 7.21594C4.58187 7.2183 4.05162 7.2222 3.52142 7.2276C3.47904 7.22863 3.43672 7.23176 3.39465 7.23704V9.52709H7.47734Z" fill="${dark_bg_color}"/> <path d="M20.4521 9.53924V7.23047H10.1732C9.74857 7.23047 9.4576 7.00533 9.39683 6.63215C9.38361 6.54082 9.38899 6.44774 9.41266 6.35854C9.43632 6.26935 9.47777 6.18588 9.53453 6.11312C9.59129 6.04035 9.66217 5.97981 9.74293 5.93514C9.82368 5.89048 9.91264 5.86263 10.0044 5.85323C10.063 5.8485 10.1241 5.84849 10.1851 5.84849C13.6225 5.84849 17.06 5.84771 20.4976 5.84614C20.7076 5.83206 20.9178 5.86983 21.1097 5.95616C21.3016 6.04249 21.4694 6.1747 21.5981 6.34115C21.7306 6.51408 21.8124 6.72041 21.8344 6.93712C21.8422 7.01981 21.8454 7.10289 21.8438 7.18593C21.8462 10.6232 21.8478 14.0607 21.8486 17.4985C21.8587 17.5994 21.8488 17.7013 21.8194 17.7983C21.79 17.8954 21.7417 17.9856 21.6773 18.0639C21.5908 18.1628 21.478 18.2349 21.352 18.2719C21.226 18.3089 21.0921 18.3092 20.966 18.2727C20.8399 18.2362 20.7267 18.1645 20.6399 18.066C20.5531 17.9675 20.4962 17.8463 20.4759 17.7166C20.4643 17.6342 20.4587 17.5511 20.459 17.468V11.1001C20.459 10.9125 20.459 10.9124 20.2689 10.9124H13.8329C13.6594 10.9278 13.4866 10.8766 13.3494 10.7693C13.2122 10.6619 13.1209 10.5064 13.0941 10.3343C13.0673 10.1622 13.1068 9.98634 13.2048 9.84231C13.3028 9.69829 13.4518 9.59688 13.6218 9.55865C13.7078 9.54408 13.795 9.53778 13.8822 9.53977H20.4519L20.4521 9.53924Z" fill="${dark_bg_color}"/> <path d="M8.92513 14.8343C8.9263 15.1538 8.83273 15.4664 8.65628 15.7326C8.47982 15.9989 8.22839 16.2069 7.93376 16.3303C7.63913 16.4538 7.31453 16.4871 7.00097 16.4261C6.68741 16.365 6.39899 16.2124 6.17214 15.9875C5.94529 15.7626 5.79018 15.4755 5.72645 15.1625C5.66272 14.8495 5.69321 14.5246 5.81407 14.2289C5.93494 13.9332 6.14075 13.68 6.40549 13.5013C6.67023 13.3225 6.98201 13.2262 7.30145 13.2246C7.51387 13.2233 7.72448 13.2639 7.92117 13.3441C8.11787 13.4244 8.29677 13.5427 8.44763 13.6922C8.59849 13.8418 8.71833 14.0197 8.80028 14.2157C8.88222 14.4117 8.92465 14.6219 8.92513 14.8343Z" fill="${dark_bg_color}"/> </svg>`;
const icon3 = `<svg style="stroke: NONE;" width="25" height="25" viewBox="0 0 25 25" fill="none" xmlns="http://www.w3.org/2000/svg"> <path style="fill:none" d="M12.5 24.5C19.1274 24.5 24.5 19.1274 24.5 12.5C24.5 5.87258 19.1274 0.5 12.5 0.5C5.87258 0.5 0.5 5.87258 0.5 12.5C0.5 19.1274 5.87258 24.5 12.5 24.5Z" stroke="${dark_bg_color}" stroke-miterlimit="10"/> <path d="M14.9436 9.726V10.086H17.4636V11.022H14.8716C14.7756 11.874 14.5476 12.534 14.1876 13.002C13.8396 13.458 13.3116 13.788 12.6036 13.992C11.8956 14.184 10.9356 14.28 9.72364 14.28V15.972C9.72364 17.772 10.5156 18.672 12.0996 18.672C12.8676 18.672 13.4436 18.45 13.8276 18.006C14.2116 17.562 14.4036 16.926 14.4036 16.098H15.5736C15.5616 17.274 15.2556 18.168 14.6556 18.78C14.0556 19.38 13.1976 19.68 12.0816 19.68C10.9176 19.68 10.0356 19.356 9.43564 18.708C8.83564 18.048 8.53564 17.136 8.53564 15.972V13.38C9.93964 13.38 10.9776 13.326 11.6496 13.218C12.3336 13.11 12.8256 12.894 13.1256 12.57C13.4376 12.246 13.6296 11.73 13.7016 11.022H7.67164V10.086H13.7556V9.708V7.854H7.67164V6.9H17.4636V7.854H14.9436V9.726Z" fill="${dark_bg_color}"/> <line x1="3.85355" y1="4.14645" x2="20.8536" y2="21.1464" stroke="${dark_bg_color}"/> </svg>`;
const close = `<svg style="width:100%; height:100%; stroke: NONE;" width="52" height="52" viewBox="0 0 52 52" fill="none" xmlns="http://www.w3.org/2000/svg"> <g filter="url(#filter0_d_1_7675)"> <circle cx="26" cy="24" r="16" fill="white"/> <path d="M30.988 30.1019L25.9998 25.1058L21.0116 30.1019L19.8978 28.9881L24.8939 23.9999L19.8978 19.0117L21.0116 17.8979L25.9998 22.894L30.988 17.9058L32.0939 19.0117L27.1057 23.9999L32.0939 28.9881L30.988 30.1019Z" fill="${dark_bg_color}"/> </g> <defs> <filter id="filter0_d_1_7675" x="0" y="0" width="52" height="52" filterUnits="userSpaceOnUse" color-interpolation-filters="sRGB"> <feFlood flood-opacity="0" result="BackgroundImageFix"/> <feColorMatrix in="SourceAlpha" type="matrix" values="0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 127 0" result="hardAlpha"/> <feOffset dy="2"/> <feGaussianBlur stdDeviation="5"/> <feComposite in2="hardAlpha" operator="out"/> <feColorMatrix type="matrix" values="0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0.1 0"/> <feBlend mode="normal" in2="BackgroundImageFix" result="effect1_dropShadow_1_7675"/> <feBlend mode="normal" in="SourceGraphic" in2="effect1_dropShadow_1_7675" result="shape"/> </filter> </defs> </svg>`;
const pie_1_3= `<svg  style="width:100%; height:100%;  stroke: NONE;" xmlns="http://www.w3.org/2000/svg" width="56" height="56" viewBox="0 0 56 56" fill="none"> <circle cx="28" cy="28" r="28" fill="${dark_bg_color}" fill-opacity="0.2"/> <path d="M28 0C32.8653 0 37.6467 1.26775 41.8728 3.67832C46.099 6.08888 49.6241 9.55906 52.1008 13.7468C54.5774 17.9346 55.9201 22.6955 55.9965 27.5602C56.073 32.4249 54.8805 37.2256 52.5366 41.4891L28 28L28 0Z" fill="${dark_bg_color}"/> </svg>`;
const pie_2_3= `<svg style="width:100%; height:100%;  stroke: NONE;" xmlns="http://www.w3.org/2000/svg" width="56" height="56" viewBox="0 0 56 56" fill="none"> <circle cx="28" cy="28" r="28" fill="${dark_bg_color}" fill-opacity="0.2"/> <path d="M28 0C32.8653 0 37.6467 1.26775 41.8728 3.67832C46.099 6.08888 49.6241 9.55906 52.1008 13.7468C54.5774 17.9346 55.9201 22.6955 55.9965 27.5602C56.073 32.4249 54.8805 37.2256 52.5366 41.4891C50.1927 45.7526 46.7783 49.3318 42.63 51.8739C38.4816 54.416 33.7424 55.8334 28.8795 55.9862C24.0166 56.139 19.1978 55.0221 14.898 52.7454C10.5982 50.4688 6.96579 47.1111 4.35882 43.0032L28 28L28 0Z" fill="${dark_bg_color}"/> </svg>`;
const pie_3_3= `<svg style="width:100%; height:100%;  stroke: NONE;" xmlns="http://www.w3.org/2000/svg" width="56" height="56" viewBox="0 0 56 56" fill="none"> <circle cx="28" cy="28" r="28" fill="${dark_bg_color}" fill-opacity="0.24"/> <circle cx="28" cy="28" r="28" transform="rotate(-90 28 28)" fill="${dark_bg_color}"/> </svg>`;
const header_bg = `<svg style="stroke: NONE;" width="100%" height="100%" viewBox="0 0 294 101" fill="none" xmlns="http://www.w3.org/2000/svg"> <g clip-path="url(#clip0_344_120)"> <rect width="100%" height="100%" rx="4" fill="${dark_bg_color}"/> <g filter="url(#filter0_d_344_120)"> <path d="M0 65.5C0 65.5 24.5 79.95 62 70.5C78.5439 66.3309 109.5 42.4995 172.5 65.5C235.5 88.5005 294 48 294 48V138H0V65.5Z" fill="white" fill-opacity="0.05" shape-rendering="crispEdges"/> </g> </g> <defs> <filter id="filter0_d_344_120" x="-25" y="22" width="344" height="140" filterUnits="userSpaceOnUse" color-interpolation-filters="sRGB"> <feFlood flood-opacity="0" result="BackgroundImageFix"/> <feColorMatrix in="SourceAlpha" type="matrix" values="0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 127 0" result="hardAlpha"/> <feOffset dy="-1"/> <feGaussianBlur stdDeviation="12.5"/> <feComposite in2="hardAlpha" operator="out"/> <feColorMatrix type="matrix" values="0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0.16 0"/> <feBlend mode="normal" in2="BackgroundImageFix" result="effect1_dropShadow_344_120"/> <feBlend mode="normal" in="SourceGraphic" in2="effect1_dropShadow_344_120" result="shape"/> </filter> <clipPath id="clip0_344_120"> <rect width="294" height="101" rx="4" fill="white"/> </clipPath> </defs> </svg>`;

let brand_logo_light =
  `https://d30flbpbaljuso.cloudfront.net/shopify-messaging-app/${partnerId}/light_logo.png`;

var brand_logo_dark =
  `https://d30flbpbaljuso.cloudfront.net/shopify-messaging-app/${partnerId}/dark_logo.png`;

const secondary_logo =
  `https://d30flbpbaljuso.cloudfront.net/shopify-messaging-app/${partnerId}/secondary.png`;


/*------------------------------------------------------------------------- product page -------------------------------------------------------------------------*/

const productWidgetEnabled = true;

const applyProductPriceLimit= false;
const productWidgetLowerLimit = 100000;
const productWidgetUpperLimit = 1000000;


/* ---------------------------------- product page locations ---------------------------------- */

var shopify_product_price_locations = [
  { location: ".price.pewc-main-price ins .woocommerce-Price-amount.amount", type: "query" },
];

var shopify_product_box_location = [
    {location :".product-price-summary.exclamation-mark.open", type: "query",  position: "after"},
  { location: "/html/body/div[1]/div/main/div[2]/div/div[1]/div/div[2]/div[1]/div[8]", type: "xpath", position: "after" },
  { location: "/html/body/div/div/main/div[2]/div/div[1]/div/div[2]/div[1]/div[7]", type: "xpath", position: "after"},
  {location: ".product-options-container", type: "query", position: "before"},
];


/* ---------------------------------- product page style ---------------------------------- */

const productWidgetStyle = {
    "desktop": {
        "logo-height": "2.3em",
        "content-font-size": "1.1em",
        "discription-font-size": "0.9em"
    },
    "mobile": {
        "logo-height": "2.6em",
        "content-font-size": "0.9em",
        "discription-font-size": "0.7em"
    },
    "mobile-small": {
        "logo-height": "2.6em",
        "content-font-size": "0.9em",
        "discription-font-size": "0.7em"
    },
    "mobile-extra-small":{
        "logo-height": "2.6em",
        "content-font-size": "0.9em",
        "discription-font-size": "0.7em"
    }
}

/*------------------------------------------------------------------------- cart page -------------------------------------------------------------------------*/

const cartWidgetEnabled = false;

/* ---------------------------------- product page locations ---------------------------------- */

var shopify_cart_price_locations = [
    { location: "ProductPrice", type: "id" },
];

var shopify_cart_box_location = [
    { location: ".product-single__policies.rte", position: "after" },
]

/* ---------------------------------- cart page style ---------------------------------- */

const cartWidgetStyle = {
    "desktop": {
        "logo-height": "1.5em",
        "content-font-size": "0.9em",
        "discription-font-size": "0.7em"
    },
    "mobile": {
        "logo-height": "1.5em",
        "content-font-size": "0.9em",
        "discription-font-size": "0.7em"
    },
    "mobile-small": {
        "logo-height": "1.5em",
        "content-font-size": "0.9em",
        "discription-font-size": "0.7em"
    },
    "mobile-extra-small":{
        "logo-height": "1.5em",
        "content-font-size": "0.9em",
        "discription-font-size": "0.7em"
    }
}



/*------------------------------------------------------------------------- checkout page -------------------------------------------------------------------------*/

const checkoutWidgetEnabled = false;

/* ---------------------------------- checkout page locations ---------------------------------- */


var checkout_price_location = [
    { location: "ProductPrice", type: "id" },
];


/* ---------------------------------- checkout page style ---------------------------------- */

const checkoutWidgetStyle = {
    "desktop": {
        "logo-height": "1.5em",
        "content-font-size": "0.9em",
        "discription-font-size": "0.7em"
    },
    "mobile": {
        "logo-height": "1.5em",
        "content-font-size": "0.9em",
        "discription-font-size": "0.7em"
    },
    "mobile-small": {
        "logo-height": "1.5em",
        "content-font-size": "0.9em",
        "discription-font-size": "0.7em"
    },
    "mobile-extra-small":{
        "logo-height": "1.5em",
        "content-font-size": "0.9em",
        "discription-font-size": "0.7em"
    }
}


/*------------------------------------------------------------------------- popup ui -------------------------------------------------------------------------*/


/* ---------------------------------- popup ui content ---------------------------------- */

const catch_phrase = "Shop the latest trends with";
const checkoutUrl = "https://www.ergoyou.in/checkout/";
const buttonEnabled = false;
const flexibleEmiEnabled = false;

/* ---------------------------------- popup ui style ---------------------------------- */

const popUiStyle = {
    "headings-font-size": "1.2em",
    "sub-headings-font-size": "0.8em",
    "catch-phrase-font-size": "0.9em",
    "normal-font-size": "0.8em",
    "discription-font-size": "0.7em",
}

/*------------------------------------------------------------------------- popup ui -------------------------------------------------------------------------*/











const parser = new DOMParser();

function getXPathData(xpath) {
  return document.evaluate(
    xpath,
    document,
    null,
    XPathResult.FIRST_ORDERED_NODE_TYPE,
    null,
  ).singleNodeValue;
}

function getElement(location) {
  let element = null;
  switch (location.type) {
    case "class": {
      let index = location.index ? location.index : 0;
      element = document.getElementsByClassName(location.location)[index];
      break;
    }
    case "xpath": {
      element = getXPathData(location.location);
      break;
    }
    case "query": {
      element = document.querySelector(location.location);
      break;
    }
    case "id": {
      element = document.getElementById(location.location);
      break;
    }
    case "querySelector": {
        element = document.querySelector(location.location);
        break;
    }
    default: {
        element = document.querySelector(location.location);
        break;
    }
  }
  return element;
}

function getPrice(locations) {
  let price = null;

  for (let i = 0; i < locations.length; i++) {
    const location = locations[i];
    try {
      const element = getElement(location);
      if (element) {
        price = element.textContent;
        break;
      }
    } catch (e) {}
  }
  return price;
}

function getElementByXpath(xpath) {
  let selector;

  selector = xpath.replace(/^\s*\/\s*/g, "");
  selector = selector.replace(/\s*\/\s*/g, " > ");
  selector = selector.replace(/\[(\d+)\]/g, function (n) {
    return ":nth-of-type(" + n[1] + ")";
  });

  return document.querySelector(selector);
}

function getInstallment(productPrice) {
  let firstInstallmentPrice = 0;
  let secondInstallmentPrice = 0;
  let thirdInstallmentPrice = 0;

  thirdInstallmentPrice = Math.floor(productPrice / 3).toLocaleString("en-IN");
  secondInstallmentPrice = Math.floor(productPrice / 3).toLocaleString("en-IN");
  firstInstallmentPrice = Math.floor(productPrice / 3).toLocaleString("en-IN");

  return [firstInstallmentPrice, secondInstallmentPrice, thirdInstallmentPrice];
}

function cleanPrice(productPrice, isPaiseOverride) {
  let cleanedProductPrice = productPrice;

  if (typeof productPrice === "string") {
    cleanedProductPrice = productPrice
      .replace(/[^0-9.]+/g, "")
      .trim()
      .match(/\d+\.?\d*/);

    cleanedProductPrice = parseFloat(cleanedProductPrice);
  }
  return cleanedProductPrice;
}

function getSVGWithStyle(svgString, applyFullSize) {
  if (applyFullSize) {
    if (svgString.includes('style="')) {
      return svgString.replace(/style="/, 'style="height:100%; width:100%; ');
    } else {
      return svgString.replace(
        /<svg /,
        '<svg style="height:100%; width:100%;" ',
      );
    }
  }
  return svgString;
}

function clickEvent() {
  fetch("https://web-v2.bharatx.tech/api/webhooks/pdp", {
    headers: {
      Accept: "application/json",
      "Content-Type": "application/json",
    },
    method: "POST",
    body: JSON.stringify({
      shop: shopify_store_domain,
      notes: {},
    }),
  }).catch((err) => {});
}

function refreshProductPrice(
  price_algo_override,
  product_price_locations,
  location,
) {
  try {
    let textContent = getPrice(product_price_locations);
    if (!textContent) {
      throw new Error("Price not found");
    }

    const productPrice = getProductPrice(price_algo_override, textContent);

    const [
      firstInstallmentPrice,
      secondInstallmentPrice,
      thirdInstallmentPrice,
    ] = getInstallment(productPrice.price);

    const bxInstallment = document.getElementById(`bx-installment-${location}`);

    bxInstallment.textContent = `Rs.${firstInstallmentPrice}`;


    const modal = document.getElementById(`bx-modal-${location}`);

    if (modal && modal.style.display != "none") {
      const popupFirstInstallment2 = document.getElementById(`first-price2`);
      popupFirstInstallment2.textContent = `₹${firstInstallmentPrice}`;
      const popupsecondInstallment1 = document.getElementById(`second-price1`);
      popupsecondInstallment1.textContent = `₹${secondInstallmentPrice}`;
      const popupThirdInstallment1 = document.getElementById(`third-price1`);
      popupThirdInstallment1.textContent = `₹${thirdInstallmentPrice}`;

      let date = new Date();
      date.setMonth(date.getMonth() + 1);
      const secondDate = `${date.toLocaleString("default", { month: "short" })} ${date.getDate()}`;
      const popupSecondDate = document.getElementById(`second-date`);
      popupSecondDate.textContent = secondDate;
      date.setMonth(date.getMonth() + 1);
      const thirdDate = `${date.toLocaleString("default", { month: "short" })} ${date.getDate()}`;
      const popupThirdDate = document.getElementById(`third-date`);
      popupThirdDate.textContent = thirdDate;
    }
  } catch (e) {}
}

function getProductPrice(price_algo_override, product_price_string) {
  switch (price_algo_override) {
    case 1: {
      let price = cleanPrice(product_price_string);

      return {
        price: price,
        variant_id: -1,
      };
    }
    default: {
      let varId = window.ShopifyAnalytics.meta.selectedVariantId;
      let vars = window.ShopifyAnalytics.meta.product.variants;

      for (let x of vars) {
        if (x.id === varId) {
          return {
            price: cleanPrice(product_price, true),
            variant_id: varId,
          };
        }
      }

      return {
        price: cleanPrice(vars[0].price, true),
        variant_id: varId,
      };
    }
  }
}

async function getRedirectUrlProduct() {
  try {
    const formObject = document.querySelector("form[action='/cart/add']");

    // get form data
    const form = new FormData(formObject);

    // convert form data to json
    const data = Object.fromEntries(form.entries());

    let formData = {
      items: [
        {
          id: data.id,
          quantity: 1,
        },
      ],
    };

    await fetch(window.Shopify.routes.root + "cart/add.js", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(formData),
    });

    window.location.href = checkoutUrl;
  } catch (err) {
  }
}


function getPopupUi(location, product_price_string, price_override) {
    let price_string = null;
    if (product_price_string) {
        price_string = getPrice(product_price_string);
    }


    const productDetails = getProductPrice(
        1,
        price_string,
        location
    );

    const [firstInstallmentPrice, secondInstallmentPrice, thirdInstallmentPrice] = getInstallment(productDetails.price);

    let date = new Date();
    date.setMonth(date.getMonth() + 1);
    const secondDate = `${date.toLocaleString('default', { month: 'short' })} ${date.getDate()}`
    date.setMonth(date.getMonth() + 1);
    const thirdDate = `${date.toLocaleString('default', { month: 'short' })} ${date.getDate()}`


    const ui = `<div id="bx-dynamic-popup" style="
    background: #fff; 
    font-family: 'Plus Jakarta Sans' !important;
    width:95%; 
    height:95%;
    max-width: 400px;
    padding: 16px 0px;
    border-radius: 8px;
    line-height: normal;
    position: relative;
    ">
    <div id="bx-popup-close" style="cursor: pointer; position: absolute; top: 0; right: 0; display: flex; justify-content: center; align-items: center; border-radius: 9999px; margin-top: -24px; margin-right: -24px">
        ${getSVGWithStyle(close, adjust_svg)}
    </div>
    <div style="
        display:flex;
        flex-direction:column;
        align-items:center;
        row-gap: 10px;
        padding: 0px 12px;
        width: 100%;
    ">
        <div id="bx-dynamic-popup-header" style="
            display:flex;
            flex-direction: column;
            align-items:center;
            color: #234DA3;
            width: 100%;
            position: relative;
            overflow: hidden;
            border-radius: 4px;
        ">
            <div style="
                z-index: 1;
                width: 100%;
                padding: 15.5px 11px;
                display: flex;
                flex-direction: row;
                justify-content: space-between;
            ">  
                <div style="
                    display:flex;
                    flex-direction:column;
                    justify-content: space-between;
                ">
                    <div style= "
                        display: flex;
                        flex-direction: column;
                    ">
                        <span style="
                            font-weight: 300;
                            font-size:  ${popUiStyle["catch-phrase-font-size"]};
                            color: white;
                            opacity: 85%;
                        ">
                            ${catch_phrase}
                        </span>
                        <span style="
                            font-weight: 700;
                            font-size:  ${popUiStyle["headings-font-size"]};
                            color: white;
                        ">
                            3 Interest Free EMIs
                        </span>
                    </div>
                    <div style="
                        display: flex;
                        align-items: center;
                        flex-direction: row;
                        margin-top: 13px;
                    ">
                        <span style="
                            font-size:  ${popUiStyle["normal-font-size"]};
                            font-weight: 300;
                            color:white;
                        ">
                            select
                        </span>
                        <img id="popup_header_image" src="${brand_logo_dark}" style="width: 3.6em;margin: 0px 4px;">
                        <span style="
                            font-size:  ${popUiStyle["normal-font-size"]};
                            font-weight: 300;
                            color:white;
                        ">
                            at checkout
                        </span>
                    </div>
                </div>
                <img src="${secondary_logo}" style="
                    width: 4.5em;
                    height: 4.5em;
                "/>
            </div>
            <div style= "
                position: absolute;
                width:100%;
            ">
                ${getSVGWithStyle(header_bg, adjust_svg)}
            </div>
        </div>
        <div style="
            display:grid;
            grid-template-columns: repeat(3, 1fr);
            justify-content: center;
            align-items:center;
            margin-top: 8px;
            color: ${dark_bg_color};
            font-weight: 300;
            background:  rgba(49, 49, 49, 0.10);
            width: 100%;
            padding: 10px 10px;
            border-radius: 4px;
            opacity: 85%;
        ">
            <div style="
                display:flex;
                flex-direction:column;
                align-items:center;
                gap: 4px;
            ">
                <div style="width:1.7em">
                    ${getSVGWithStyle(icon1, adjust_svg)}
                </div>
                <span style="
                    text-align:center;
                    font-size: ${popUiStyle["discription-font-size"]};
                    color: ${dark_bg_color};
                ">Instant <br> Approval
                </span>
            </div>
            <div style="
                display:flex;
                flex-direction:column;
                align-items:center;
                gap: 4px;
    
            ">
                <div style="width:1.7em">
                    ${getSVGWithStyle(icon2, adjust_svg)}
                </div>
                <span style="
                    text-align:center;
                    font-size: ${popUiStyle["discription-font-size"]};
                    color: ${dark_bg_color};
                ">Pay via UPI,<br> No card required
                </span>
            </div>
            <div style="
                display:flex;
                flex-direction:column;
                align-items:center;
                gap: 4px;
    
            ">
                <div style="width:1.7em">
                    ${getSVGWithStyle(icon3, adjust_svg)}
                </div>
                <span style="
                    text-align:center;
                    font-size: ${popUiStyle["discription-font-size"]};
                    color: ${dark_bg_color};
                ">No Additional <br> Charges
                </span>
            </div>
        </div>
    </div>
    <div style="
        display:flex;
        flex-direction:column;
        align-items:center;
        row-gap: 4px;
        padding: 12px 12px;
    ">
        <div style="
            display:grid;
            grid-template-columns: repeat(3, 1fr);
            gap: 2.2em;
            justify-content: center;
            align-items:center;
            margin-top: 8px;
            color: #393939;
        ">
            <div style="
                display:flex;
                flex-direction:column;
                align-items:center;
                row-gap: 8px;
                padding: 4px;
                color: #393939;
            ">
                ${getSVGWithStyle(pie_1_3, adjust_svg)}
                <div style= "display: flex; flex-direction:column;
                align-items:center;
                ">

                    <span style="
                        font-size: ${popUiStyle["discription-font-size"]};
                        font-weight: 600;
                        text-align:center;
                        white-space: nowrap;
                    ">
                        Pay <span id ="first-price2" style="font-weight:900">₹${firstInstallmentPrice}</span>
                    </span>
                    <span style="
                        font-size: ${popUiStyle["discription-font-size"]};
                        font-weight: 600;
                        text-align:center;
                    ">
                    Today
                    </span>
                </div>
            </div>
            <div style="
                display:flex;
                flex-direction:column;
                align-items:center;
                row-gap: 8px;
                padding: 4px;
            ">
                ${getSVGWithStyle(pie_2_3, adjust_svg)}
                <div style= "display: flex; flex-direction:column;
                align-items:center;
                ">

                    <span style="
                        font-size: ${popUiStyle["discription-font-size"]};
                        font-weight: 300;
                        text-align:center;
                        white-space: nowrap;
                    ">
                        Pay <span id ="second-price1" style="font-weight:900">₹${secondInstallmentPrice}</span>
                    </span>
                    <span id="second-date" style="
                        font-size: ${popUiStyle["discription-font-size"]};
                        font-weight: 300;
                        text-align:center;
                    ">
                    on ${secondDate}
                    </span>
                </div>
            </div>
            <div style="
                display:flex;
                flex-direction:column;
                align-items:center;
                row-gap: 8px;
                padding: 4px;
            ">
                ${getSVGWithStyle(pie_3_3, adjust_svg)}
                <div style= "display: flex; flex-direction:column;
                align-items:center;
                ">

                    <span style="
                        font-size: ${popUiStyle["discription-font-size"]};
                        font-weight: 300;
                        text-align:center;
                        white-space: nowrap;
                    ">
                        Pay <span id ="third-price1" style="font-weight:900">₹${thirdInstallmentPrice}</span>
                    </span>
                    <span id="third-date" style="
                        font-size: ${popUiStyle["discription-font-size"]};
                        font-weight: 300;
                        text-align:center;
                    ">
                    on ${thirdDate}
                    </span>
                </div>
            </div>
        </div>
        ${buttonEnabled ? `
        <button 
            id="bx-popup-btn"
            onclick="getRedirectUrlProduct()"
            style="
            cursor: pointer;
            color: #fff;
            background: ${dark_bg_color};
            border-radius: 4px;
            border: 0;
            font-size:  ${popUiStyle["sub-headings-font-size"]};
            width: 100%;
            font-weight: 500;
            padding: 12px 0px;
            margin-top: 16px;
        ">
            Buy on EMI
        </button>
        `: ``}
    </div>
    ${buttonEnabled ? `
    <div style=" 
        margin-bottom: 8px;
        display: flex;
        align-items: center;
        justify-content: center;
        padding: 0px 12px;
    ">
        <div style="display:flex; flex:auto">
        <hr style="
            border: .7px solid #ADADAD;
            width: 100%;
            margin:0px;
        ">
        </div>
        <span id="divider" style="
            font-size: ${popUiStyle["discription-font-size"]};
            color:#ADADAD;
            font-weight: 400;
            background:#fff; 
            margin: 0px 8px;
        ">or</span>
        <div style="display:flex; flex:auto">
        <hr style="
            border: .7px solid #ADADAD;
            width: 100%;
            margin:0px;
        ">
        </div>
    </div>`
            : ``}
    <div style= "padding: 0px 12px">
        <div style="
            display:flex;
            flex-direction:row;
            justify-content:center;
            align-items:center;
            font-weight: 600;
            margin-bottom: 14px;
            color: #393939;
        ">
            <span style="
                font-size:  ${popUiStyle["sub-headings-font-size"]};
            ">
                Select
            </span>
            <img src="${brand_logo_light}" style="width: 4.5em;margin: 0px 5px;">
            <span style="
                font-size:  ${popUiStyle["sub-headings-font-size"]};
            ">
            at the payment screen
            </span>
        </div>
        <div style="
            padding: 8px 0px;
            display:grid;
            grid-template-columns: repeat(3, auto);
            gap: auto;
            line-height: 18px;
            border: 1px solid #E9E9E9;
            border-radius: 4px;
        ">
            <div style="
                display:flex;
                flex-direction:column;
                align-items:center;
                text-align:center;
                color: #393939;
            ">
                <span style="
                    display: flex;
                    padding: 2px 8px;
                    justify-content: center;
                    align-items: center;
                    gap: 10px;
                    border-radius: 10px;
                    border: 1px solid ${dark_bg_color};
                    width: fit-content;
                    color: ${dark_bg_color};
                    font-size:  ${popUiStyle["discription-font-size"]};
                    font-weight: 300;
                    margin-bottom: 10px;
                ">
                    Step 1
                </span>
                <span style="
                    font-size: ${popUiStyle["discription-font-size"]};
                    font-weight: 300;
                    line-height: 1.5em;
                ">
                    Add products to cart
                </span>
                <div style="
                    display: flex;
                    align-items: center;
                ">
                    <span  style="
                    font-size:  ${popUiStyle["discription-font-size"]};
                    font-weight: 300;
                ">& select</span>
                    <img src="${brand_logo_light}" style="width: 3.2em;margin: 0px 4px;">
                </div>
            </div>
            <div style="
                display:flex;
                flex-direction:column;
                align-items:center;
                text-align:center;
                color: #393939;
            ">
                <span style="
                    display: flex;
                    padding: 2px 8px;
                    justify-content: center;
                    align-items: center;
                    gap: 10px;
                    border-radius: 10px;
                    border: 1px solid ${dark_bg_color};
                    width: fit-content;
                    color: ${dark_bg_color};
                    font-size: ${popUiStyle["discription-font-size"]};
                    font-weight: 300;
                    margin-bottom: 10px;
                ">
                    Step 2
                </span>
                <span style="
                    font-size:  ${popUiStyle["discription-font-size"]};
                    font-weight: 300;
                    line-height: 1.5em;
                ">
                    Enter <br> OTP
                </span>
            </div>
            <div style="
                display:flex;
                flex-direction:column;
                align-items:center;
                text-align:center;
                color: #393939;
            ">
                <span style="
                    display: flex;
                    padding: 2px 8px;
                    justify-content: center;
                    align-items: center;
                    gap: 10px;
                    border-radius: 10px;
                    border: 1px solid ${dark_bg_color};
                    width: fit-content;
                    color: ${dark_bg_color};
                    font-size: ${popUiStyle["discription-font-size"]};
                    font-weight: 300;
                    margin-bottom: 10px;
                ">
                    Step 3
                </span>
                <span style="
                    font-size: ${popUiStyle["discription-font-size"]};
                    font-weight: 300;
                    line-height: 1.5em;
                ">
                    Pay downpayment <br> via UPI
                </span>
            </div>
        </div>

        ${
            flexibleEmiEnabled
              ? `<div style="
              display:grid;
              justify-content: center;
              align-items:center;
              margin-top: 8px;
              color: ${dark_bg_color};
              font-weight: 300;
              background: ${rgba_backgroud};
              width: 100%;
              padding: 4px;
              border-radius: 4px;
              font-size:  ${popUiStyle["discription-font-size"]};
          ">
          Flexible EMI options also available on checkout
          </div>`
              : ``
          }
    </div>
    </div>`;
    return ui;
}



function loadBxModal(location, price_location) {
  var modalContainer = document.createElement("div");
  modalContainer.id = "modal-container";
  document.body.appendChild(modalContainer);

  var modal_html = `<div id="bx-modal-${location}" style="display: none;justify-content: center; position: fixed; z-index: 2147483649;left: 0; top: 0; border: 0 ;width: 100%; max-width: 100%; height: 100vh; background-color: rgb(18,18,18,0.55); overflow: auto; opacity : 1;"> 
            <div class="bx-modal-content" style="background-color: #fefefe; background: transparent; width: 40%;min-width: 360px; display: flex; align-items: center; justify-content: center; border: 0; position: relative"> 
                <div class="image" style = "
                    position: absolute;
                    display: flex;
                    justify-content: center;
                    width: 100%;
                    font-size: 17px;
                "> 
                ${getPopupUi(location, price_location, 1)} 
                </div> 
            </div>
            <div id="pop-up-overlay" style= "width:100%; height:100%; position: fixed;z-index:-1">
            </div>
        </div>`;

  var modalContainer = document.getElementById("modal-container");
  var modal = document.getElementById(`bx-modal-${location}`);
  var btn = document.getElementById(
    `bharatx-text-block-with-price-${location}`,
  );

  if (btn != null) {
    btn.onclick = function () {
      if (modal == null) {
        modalContainer.innerHTML = modal_html;
        modal = document.getElementById(`bx-modal-${location}`);
        var button = document.getElementById("bx-popup-close");
        button.onclick = function () {
          modal.style.display = "none";
        };
        var overlay = document.getElementById("pop-up-overlay");
        overlay.onclick = function () {
          modal.style.display = "none";
        };
      }
      modal = document.getElementById(`bx-modal-${location}`);
      modal.style.display = "flex";
      // clickEvent();
    };
  }
}


function new_product(price_override, product_price_locations, location) {

  var price_string = null;
  if (product_price_locations) {
    price_string = getPrice(product_price_locations);
    if (!price_string) {
      throw new Error("Price not found");
    }
  }

  const productDetails = getProductPrice(
    price_override,
    price_string,
    location,
  );

    if (applyProductPriceLimit && (productDetails.price < productWidgetLowerLimit || productDetails.price > productWidgetUpperLimit)) {
        return null;
    }
  const [firstInstallmentPrice, secondInstallmentPrice, thirdInstallmentPrice] =
    getInstallment(productDetails.price);

  const frontend = `
    <div id = "bx-ui-box-${location}" style="font-family: 'Plus Jakarta Sans' !important; margin-bottom: 10px">
    <div id="bharatx-text-block-with-price-${location}" style="
        display: flex; 
        align-items: center; 
        flex-direction: row; 
        padding: 5px 5px; 
        border: 1px solid ${dark_bg_color};
        border-radius: 5px;
        gap: 7px;
        width: fit-content;
        margin-top: 10px;
        cursor: pointer;
        font-size: 16px;
        ">
            <img id="bx-${location}-logo" style="height: 1.5vw;display:inline !important;margin: 0px; padding: 0px" src="${brand_logo_light}"/>
            <div style="
                display: flex; 
                align-items: flex-start;
                flex-direction: column;
                gap: 5px;
            "> 
            
                <span id ="bx-${location}-text" style="
                padding: 0px 3px;  
                font-size:  
                font-family: system-ui; 
                color: black
                ">
                    Pay
                    <span style="" id="bx-installment-${location}"> 
                    ₹${firstInstallmentPrice} 
                    </span> 
                    now &amp; rest later 
                </span>
                <p id="bx-${location}-text2" style="line-height: 14px;font-size: 0.7vw;color: #898989;padding: 0px 2px;margin:0"> 
            0% Interest | No Credit Card Required
            </div> 
            
        </p>
        </div> 
    </div>`;

  return frontend;
}

function loadInfoBanner(price_location, box_location, location) {
  const ui = new_product(1, price_location, location);
  if (!ui ) return;
  if (!document.getElementById("bx-ui-box-product")) {
    for (var i = 0; i < box_location.length; i++) {
      var referenceNode = getElement(box_location[i]);
      if (referenceNode) {

        if (box_location[i].position && box_location[i].position == "before") {
            referenceNode.parentNode.insertBefore(
                parser.parseFromString(ui, "text/html").body.childNodes[0],
                referenceNode
            );
            break;
        }

        if (box_location[i].position && box_location[i].position == "after") {
            referenceNode.parentNode.insertBefore(
                parser.parseFromString(ui, "text/html").body.childNodes[0],
                referenceNode.nextElementSibling
            );
            break;
        }

        const domObject = parser.parseFromString(ui, "text/html").body
          .childNodes[0];
        referenceNode.appendChild(domObject);
        break;
      }
    }
  }
}

function loadCartBanner() {
  const ui = getUiForCart(1, shopify_cart_price_locations, "cart");
  if (document.getElementById("bx-ui-box-cart") == null) {
    for (var i = 0; i < shopify_cart_box_location.length; i++) {
      const referenceNode = getElement(shopify_cart_box_location[i]);
      if (referenceNode) {
        const domObject = parser.parseFromString(ui, "text/html").body
          .childNodes[0];
        referenceNode.parentNode.insertBefore(
          domObject,
          referenceNode.nextElementSibling,
        );
        break;
      }
    }
  }
}

function getUiForCart(price_override, product_price_locations, location) {
  var price_string = null;
  if (product_price_locations) {
    price_string = getPrice(product_price_locations);
    if (!price_string) {
      throw new Error("Price not found");
    }
  }

  const productDetails = getProductPrice(
    price_override,
    price_string,
    location,
  );
  const [firstInstallmentPrice, secondInstallmentPrice, thirdInstallmentPrice] =
    getInstallment(productDetails.price);

  const frontend = `
    <div id = "bx-ui-box-cart" style= "width:100%;margin-top: 10px; font-family: 'Plus Jakarta Sans' !important;">
    <div id="bharatx-text-block-with-price-${location}" style="
         display: flex; 
         align-items: center; 
         flex-direction: row; 
         padding: 5px 5px; 
         border: 1px solid ${dark_bg_color};
         border-radius: 5px;
         width: fit-content;
         gap: 5px;
        ">
            <img id="bx-cart-logo" style="height: 1.5vw;display:inline !important;margin: 0px; padding: 0px" src="${brand_logo_light}"/>
            <div style="
                display: flex; 
                align-items: flex-start;
                flex-direction: column;
            "> 
            
                <span id ="bx-cart-text" style="
                padding: 0px 3px;  
                font-size: 0.9vw; 
                font-family: system-ui;
                color: black;
                ">
                    Pay
                    <span style="font-weight:600" id="bx-installment-cart"> 
                    ₹${firstInstallmentPrice} 
                    </span> 
                    now &amp; rest later 
                </span>
                <p id="bx-cart-text2" style="line-height: 14px;font-size: 0.7vw;color: #898989;padding: 4px 2px; margin:0"> 
            0% Interest | No Credit Score or App Needed
            </div> 
        </p>
        </div> 
    </div>`;
  return frontend;
}

function checkout() {
  const price_string = getPrice(checkout_price_location);
  const productDetails = getProductPrice(1, price_string, "checkout");

  const [firstInstallmentPrice, secondInstallmentPrice, thirdInstallmentPrice] =
    getInstallment(productDetails.price);

  const frontend = `
    <div id = "bx-ui-box-checkout">
    <div id="bx-img" style="
         display: flex; 
         align-items: center; 
         flex-direction: row; 
        ">
            <img id="bx-checkout-logo" style="height: 1.5vw;display:inline !important;margin: 0px; padding: 0px" src="${brand_logo_light}"/>
            <div style="
                display: flex; 
                align-items: flex-start;
                flex-direction: column;
            "> 
            
                <span id ="bx-checkout-text" style="
                padding: 0px 3px;  
                font-size: 0.9vw; 
                font-family: system-ui; 
                color: black;
                ">
                    Pay
                    <span style="" id="bx-installment-checkout"> 
                    ₹${firstInstallmentPrice} 
                    </span> 
                    now &amp; rest later 
                </span>
                <p id="bx-checkout-text2" style="line-height: 14px;font-size: 0.7vw;color: #898989;padding: 4px 2px;"> 
            0% Interest | No Credit Score or App Needed
            </div> 
            
        </p>
        </div> 
    </div>`;

  return frontend;
}

let prevCartPrice = null;
let prevScreen = null;
let prevProductPrice = null;
let prevCheckoutScreen = null;
let prevCheckoutPrice = null;
let rerenderCount = 20;
let isCartWidgetAdded = false;

function bxOps() {
  try {
    if (
      productWidgetEnabled &&
      document.getElementById("bx-ui-box-product") == null
    ) {
      loadInfoBanner(
        shopify_product_price_locations,
        shopify_product_box_location,
        "product",
      );
      loadBxModal("product", shopify_product_price_locations);
    }
  } catch (e) {}
  try {
    if (
      cartWidgetEnabled &&
      document.getElementById("bx-ui-box-cart") == null
    ) {
      loadCartBanner();
      loadBxModal("cart", shopify_cart_price_locations);
    }
  } catch (e) {}

  try {
    if (productWidgetEnabled && document.getElementById("bx-ui-box-product")) {
      if (prevProductPrice != getPrice(shopify_product_price_locations)) {
        prevProductPrice = getPrice(shopify_product_price_locations);
        refreshProductPrice(1, shopify_product_price_locations, "product");
      }
    }

    if (cartWidgetEnabled && document.getElementById("bx-ui-box-cart")) {
      if (prevCartPrice != getPrice(shopify_cart_price_locations)) {
        prevCartPrice = getPrice(shopify_cart_price_locations);
        refreshProductPrice(1, shopify_cart_price_locations, "cart");
      }
    }
  } catch (e) {}
  try {
    if (checkoutWidgetEnabled) {
      const label = document.querySelector(
        'label[for="payment_method_bharatx-pay-in-3-feature-plugin"]',
      );

      if (label && document.getElementById("bx-ui-box-checkout") == null) {
        label.innerHTML = checkout();
      }
    }
  } catch (e) {}

  try {
    if (cartWidgetEnabled && document.getElementById("bx-ui-box-checkout")) {
      if (prevCheckoutPrice != getPrice(checkout_price_location)) {
        prevCheckoutPrice = getPrice(checkout_price_location);
        refreshProductPrice(1, checkout_price_location, "checkout");
      }
    }
  } catch (e) {}

  try {
    if (checkoutWidgetEnabled) {
      const x = window.matchMedia("(max-width: 750px)");
      const y = window.matchMedia("(max-width: 400px)");
      const z = window.matchMedia("(max-width: 300px)");

      const checkoutLogo = document.getElementById("bx-checkout-logo");
      const checkoutText = document.getElementById("bx-checkout-text");
      const checkoutText2 = document.getElementById("bx-checkout-text2");

      if (
        (!x.matches && rerenderCount > 0) ||
        (!x.matches && prevScreen != "desktop")
      ) {
        checkoutLogo.style.height =  checkoutWidgetStyle["desktop"]["logo-height"]
        checkoutText.style.fontSize = checkoutWidgetStyle["desktop"]["content-font-size"]
        checkoutText2.style.fontSize =  checkoutWidgetStyle["desktop"]["discription-font-size"]
      }

      if (
        ((x.matches && !y.matches && !z.matches) && rerenderCount > 0) ||
        ((x.matches && !y.matches && !z.matches) && prevScreen != "mobile")
      ) {
        checkoutLogo.style.height =  checkoutWidgetStyle["mobile"]["logo-height"]
        checkoutText.style.fontSize =  checkoutWidgetStyle["mobile"]["content-font-size"]
        checkoutText2.style.fontSize =  checkoutWidgetStyle["mobile"]["discription-font-size"]
      }

      if (
        ((y.matches && !z.matches) && rerenderCount > 0) ||
        ((y.matches && !z.matches) && prevScreen != "mobile-small")
      ) {
        checkoutLogo.style.height =  checkoutWidgetStyle["mobile-small"]["logo-height"]
        checkoutText.style.fontSize =  checkoutWidgetStyle["mobile-small"]["content-font-size"]
        checkoutText2.style.fontSize =  checkoutWidgetStyle["mobile-small"]["discription-font-size"]
      }

      if (
        (z.matches && rerenderCount > 0) ||
        (z.matches && prevScreen != "mobile-extra-small")
      ) {
        checkoutLogo.style.height =  checkoutWidgetStyle["mobile-extra-small"]["logo-height"]
        checkoutText.style.fontSize = checkoutWidgetStyle["mobile-extra-small"]["content-font-size"]
        checkoutText2.style.fontSize = checkoutWidgetStyle["mobile-extra-small"]["discription-font-size"]
      }
    }
  } catch (e) {}

  try {
    if (cartWidgetEnabled) {
      const x = window.matchMedia("(max-width: 750px)");
      const y = window.matchMedia("(max-width: 400px)");
      const z = window.matchMedia("(max-width: 300px)");

      const cartLogo = document.getElementById("bx-cart-logo");
      const cartText = document.getElementById("bx-cart-text");
      const cartText2 = document.getElementById("bx-cart-text2");
      if (
        (!x.matches && (rerenderCount > 0 || !isCartWidgetAdded)) ||
        (!x.matches && prevScreen != "desktop")
      ) {
        cartLogo.style.height = cartWidgetStyle["desktop"]["logo-height"]
        cartText.style.fontSize = cartWidgetStyle["desktop"]["content-font-size"]
        cartText2.style.fontSize =  cartWidgetStyle["desktop"]["discription-font-size"]
      }

      if (
        ((x.matches && !y.matches && !z.matches) && (rerenderCount > 0 || !isCartWidgetAdded)) ||
        ((x.matches && !y.matches && !z.matches) && prevScreen != "mobile")
      ) {
        cartLogo.style.height =  cartWidgetStyle["mobile"]["logo-height"]
        cartText.style.fontSize =  cartWidgetStyle["mobile"]["content-font-size"]
        cartText2.style.fontSize =  cartWidgetStyle["mobile"]["discription-font-size"]
      }

      if (
        ((y.matches && !z.matches) && (rerenderCount > 0 || !isCartWidgetAdded)) ||
        ((y.matches && !z.matches) && prevScreen != "mobile-small")
      ) {

        cartLogo.style.height =  cartWidgetStyle["mobile-small"]["logo-height"]
        cartText.style.fontSize = cartWidgetStyle["mobile-small"]["content-font-size"]
        cartText2.style.fontSize = cartWidgetStyle["mobile-small"]["discription-font-size"]
      }

      if (
        (z.matches && (rerenderCount > 0 || !isCartWidgetAdded)) ||
        (z.matches && prevScreen != "mobile-extra-small")
      ) {
        cartLogo.style.height =  cartWidgetStyle["mobile-extra-small"]["logo-height"]
        cartText.style.fontSize = cartWidgetStyle["mobile-extra-small"]["content-font-size"]
        cartText2.style.fontSize =  cartWidgetStyle["mobile-extra-small"]["discription-font-size"]
      }
    }
  } catch (e) {}

  try {
    if (productWidgetEnabled) {
      const x = window.matchMedia("(max-width: 750px)");
      const y = window.matchMedia("(max-width: 400px)");
      const z = window.matchMedia("(max-width: 300px)");

      const productLogo = document.getElementById("bx-product-logo");
      const productText = document.getElementById("bx-product-text");
      const productText2 = document.getElementById("bx-product-text2");

      if (
        (!x.matches && rerenderCount > 0) ||
        (!x.matches && prevScreen != "desktop")
      ) {
        productLogo.style.height = productWidgetStyle["desktop"]["logo-height"]
        productText.style.fontSize =  productWidgetStyle["desktop"]["content-font-size"]
        productText2.style.fontSize =  productWidgetStyle["desktop"]["discription-font-size"]
      }

      if (
        ((x.matches && !y.matches && !z.matches) && rerenderCount > 0) ||
        ((x.matches && !y.matches && !z.matches) && prevScreen != "mobile")
      ) {

        productLogo.style.height =  productWidgetStyle["mobile"]["logo-height"]
        productText.style.fontSize =  productWidgetStyle["mobile"]["content-font-size"]
        productText2.style.fontSize =  productWidgetStyle["mobile"]["discription-font-size"]
      }

      if (
        ((y.matches && !z.matches) && rerenderCount > 0) ||
        ((y.matches && !z.matches) && prevScreen != "mobile-small")
      ) {

        productLogo.style.height =  productWidgetStyle["mobile-small"]["logo-height"]
        productText.style.fontSize = productWidgetStyle["mobile-small"]["content-font-size"]
        productText2.style.fontSize = productWidgetStyle["mobile-small"]["discription-font-size"]
      }

      if (
        (z.matches && rerenderCount > 0) ||
        (z.matches && prevScreen != "mobile-extra-small")
      ) {

        productLogo.style.height =  productWidgetStyle["mobile-extra-small"]["logo-height"]
        productText.style.fontSize =  productWidgetStyle["mobile-extra-small"]["content-font-size"]
        productText2.style.fontSize =  productWidgetStyle["mobile-extra-small"]["discription-font-size"]
      }
    }
  } catch (e) {}

  try {

    const x = window.matchMedia("(max-width: 750px)");
    const y = window.matchMedia("(max-width: 400px)");
    const z = window.matchMedia("(max-width: 300px)");


    if (!x.matches && prevScreen != "desktop") {
      prevScreen = "desktop";
    }

    if ((x.matches && !y.matches && !z.matches) && prevScreen != "mobile") {
      prevScreen = "mobile";
    }


    if ((y.matches && !z.matches) && prevScreen != "mobile-small") {
      prevScreen = "mobile-small";
    }

    if (z.matches && prevScreen != "mobile-extra-small") {
      prevScreen = "mobile-extra-small";
    }

  } catch (e) {}

  if (rerenderCount > 0) rerenderCount -= 1;

  try {
    if (cartWidgetEnabled) {
      if (document.getElementById("bx-ui-box-cart")) {
        isCartWidgetAdded = true;
      } else {
        isCartWidgetAdded = false;
      }
    }
  } catch (e) {}
}

function styles() {
  try {

    const head = document.getElementsByTagName("head")[0];

    const link = document.createElement("link");
    link.rel = "stylesheet";
    link.type = "text/css";
    link.href =
      "https://fonts.googleapis.com/css2?family=Plus+Jakarta+Sans:wght@300;400;500;600;700&display=swap";
    head.appendChild(link);

    const style = document.createElement("style");
    style.type = "text/css";
    style.innerHTML = `
        #bx-dynamic-popup * {
            font-family: 'Plus Jakarta Sans';
        }

        #bx-dynamic-popup-header > svg {
                width: 100%;
                height: 100%;
        }
        #bx-dynamic-popup-header  {
            background-size: cover;
            width: 100%;
            height: 100%;
        }
        `;
    head.appendChild(style);
  } catch (e) {

  }
}

function oneTimeOps(){
    try {
        var imgElement = document.querySelector('label[for="payment_method_bharatx-pay-in-3-feature-plugin"] img');
        if (imgElement) {
            imgElement.parentNode.removeChild(imgElement);
        }
    } catch (e) {
        console.log(e);
    }
}



styles();
// oneTimeOps();
// bxOps()
if (typeof Shopify !== 'undefined' && Shopify.currency && Shopify.currency.active === "INR") {
    setInterval(bxOps, 100);
  } else {
    setInterval(bxOps, 100);
  }
  
