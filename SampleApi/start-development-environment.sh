docker compose -f docker-compose.yml build --no-cache sample-api
docker compose -f docker-compose.yml up -d
docker compose -f docker-compose.yml exec api dotnet dev-certs https