docker compose -f stack.yml stop worker
docker compose -f stack.yml stop kibana
docker compose -f stack.yml stop elasticsearch

docker rm sample-worker-instance
docker rm kibana-instance
docker rm elasticsearch-instance

docker rmi -f sample-worker
docker rmi -f kibana:8.7.1
docker rmi -f elasticsearch:8.7.1