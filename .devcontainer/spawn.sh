if [[ -z $NEW_CONTAINERS ]] && [[ $doContainersExist == 0 ]]; then
    logSpawnMessage "Containers found - reusing existing Spawn containers"
else
    logSpawnMessage "No containers found - creating new Spawn containers"
    echo
    spawnctl create data-container --image $SPAWN_TODO_IMAGE_NAME --name "$todoContainerName" -q > /dev/null
    echo
    spawnctl create data-container --image $SPAWN_ACCOUNT_IMAGE_NAME --name "$accountContainerName" -q > /dev/null
fi
updateDatabaseAppSettings "$todoContainerName" "$accountContainerName"
