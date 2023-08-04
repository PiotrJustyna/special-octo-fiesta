docker compose -f stack.yml stop special-octo-fiesta
docker compose -f stack.yml stop setup
docker compose -f stack.yml stop kibana
docker compose -f stack.yml stop es01

docker rm observable-console-instance
docker rm setup-instance
docker rm kib01-instance
docker rm es01-instance

docker rmi -f special-octo-fiesta
docker rmi -f kibana:8.7.1
docker rmi -f elasticsearch:8.7.1