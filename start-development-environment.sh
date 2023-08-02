docker compose -f stack.yml up -d
docker compose -f stack.yml exec special-octo-fiesta dotnet tool restore
docker compose -f stack.yml exec special-octo-fiesta dotnet paket install