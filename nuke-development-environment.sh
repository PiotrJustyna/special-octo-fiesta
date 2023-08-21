docker compose -f docker-compose.yml stop worker
docker compose -f docker-compose.yml stop kibana
docker compose -f docker-compose.yml stop elasticsearch

docker rm worker-instance
docker rm kibana-instance
docker rm elasticsearch-instance

docker rmi -f worker
docker rmi -f docker.elastic.co/kibana/kibana:8.8.1
docker rmi -f docker.elastic.co/elasticsearch/elasticsearch:8.8.1