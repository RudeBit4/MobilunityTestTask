const PROXY_CONFIG = [
  {
    context: [
      "/weatherforecast","/api/categories"
    ],
    target: "https://localhost:7122",
    secure: false
  },
]

module.exports = PROXY_CONFIG;
