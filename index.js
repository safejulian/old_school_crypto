var key = new Buffer("");
var scrypt = require("scrypt");
var MD5 = require("crypto-js/md5");

console.log(MD5("Hash this with corned beef and a shiraz").toString());
 
var result = scrypt.hashSync(key,{"N":16,"r":1,"p":1},64,"");
console.log(result.toString("hex"));
