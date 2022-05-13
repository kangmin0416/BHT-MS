import request from '@/utils/request'

export function queryWorkshop(data) {
  return request({
    url: 'api/workshop/query',
    method: 'post',
    data
  })
}

export function getWorkshop(id) {
  return request({
    url: 'api/workshop/get?id=' + id,
    method: 'get'
  })
}

export function getAllWorkshop(enable) {
  return request({
    url: 'api/workshop/getAll' + (enable === undefined ? '' : ('?enable=' + enable)),
    method: 'get'
  })
}

export function createWorkshop(data) {
  return request({
    url: 'api/workshop/create',
    method: 'post',
    data
  })
}

export function updateWorkshop(data) {
  return request({
    url: 'api/workshop/update',
    method: 'post',
    data
  })
}

export function deleteWorkshop(id) {
  return request({
    url: 'api/workshop/delete?id=' + id,
    method: 'get'
  })
}

export default { queryWorkshop, getWorkshop, createWorkshop, updateWorkshop, deleteWorkshop }
