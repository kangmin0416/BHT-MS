import request from '@/utils/request'

export function queryTasks(data) {
  return request({
    url: 'api/tasks/query',
    method: 'post',
    data
  })
}

export function getTasks(id) {
  return request({
    url: 'api/tasks/get?id=' + id,
    method: 'get'
  })
}

export function getAllTasks() {
  return request({
    url: 'api/tasks/getAll',
    method: 'get'
  })
}

export function createTasks(data) {
  return request({
    url: 'api/tasks/create',
    method: 'post',
    data
  })
}

export function updateTasks(data) {
  return request({
    url: 'api/tasks/update',
    method: 'post',
    data
  })
}

export function deleteTasks(id) {
  return request({
    url: 'api/tasks/delete?id=' + id,
    method: 'get'
  })
}

export function startTasks(id) {
  return request({
    url: 'api/tasks/start?id=' + id,
    method: 'get'
  })
}

export function stopTasks(id) {
  return request({
    url: 'api/tasks/stop?id=' + id,
    method: 'get'
  })
}

export default { queryTasks, getTasks, getAllTasks, createTasks, updateTasks, deleteTasks, startTasks, stopTasks }
