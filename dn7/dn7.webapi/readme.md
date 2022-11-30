# webapi

## Manual docker build & run
`docker build -t dn7 . -f .\dn7.webapi\Dockerfile`
`docker run -it -p 80:80 --name dn7-a dn7 -e ASPNETCORE_URLS="http://localhost"`