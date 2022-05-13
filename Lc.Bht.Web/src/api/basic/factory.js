import request from '@/utils/request'

export function queryFactory(data) {
  return request({
    url: 'api/factory/query',
    method: 'post',
    data
  })
}

export function getFactory(id) {
  return request({
    url: 'api/factory/get?id=' + id,
    method: 'get'
  })
}

export function getAllFactory(enable) {
  return request({
    url: 'api/factory/getAll' + (enable === undefined ? '' : ('?enable=' + enable)),
    method: 'get'
  })
}

export function createFactory(data) {
  return request({
    url: 'api/factory/create',
    method: 'post',
    data
  })
}

export function updateFactory(data) {
  return request({
    url: 'api/factory/update',
    method: 'post',
    data
  })
}

export function deleteFactory(id) {
  return request({
    url: 'api/factory/delete?id=' + id,
    method: 'get'
  })
}

export default { queryFactory, getFactory, createFactory, updateFactory, deleteFactory }
