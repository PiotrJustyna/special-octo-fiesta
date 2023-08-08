http://localhost:5176/WeatherForecast

log collection works now: [kibana](http://localhost:5601/app/discover#/?_g=(filters:!(),refreshInterval:(pause:!t,value:60000),time:(from:now-15m,to:now))&_a=(columns:!(),filters:!(),index:f3e0667e-2a7a-45eb-9ea6-55a7fa0873c5,interval:auto,query:(language:kuery,query:''),sort:!(!('@timestamp',desc))))

containerised api is running, I can't just can't seem to expose the right ports:

```
docker compose -f docker-compose.yml exec api curl localhost:5176/weatherforecast
```
