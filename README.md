# Northwind_API

使用Northwind Database進行Shipper CRUD API

使用資料庫: MSSQL
Docker mcr.microsoft.com/mssql/server:2017-latest-ubuntu
DB:Northwind 
Table: Shipper


1. GET api/shipper/GetShipper

▪ param:id
▪ api/shipper/GetShipper/1

2. POST api/shipper/AddShipper

▪param: name、phone
▪pi/shipper/AddShipper
{
  "name":"EVAAIR Express",
  "phone":"(123)-666999"
}

3. PUT api/shipper/UpdateShipper

▪ param: name、phone

▪ api/shipper/UpdateShipper/2
{
  "name":"EVAAIR Express",
  "phone":"(123)-666999"
}

4. DELETE api/shipper/DeleteShipper
▪ param: id

▪ api/shipper/DeleteShipper/3
