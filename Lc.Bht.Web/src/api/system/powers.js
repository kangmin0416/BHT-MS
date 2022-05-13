import request from '@/utils/request'

// 获取所有的Power
export function queryPower(data) {
  return request({
    url: 'api/powers/query',
    method: 'post',
    data
  })
}

export function getPower(id) {
  return request({
    url: 'api/powers/get?id=' + id,
    method: 'get'
  })
}

export function createPower(data) {
  return request({
    url: 'api/powers/create',
    method: 'post',
    data
  })
}

export function updatePower(data) {
  return request({
    url: 'api/powers/update',
    method: 'post',
    data
  })
}

export function deletePower(id) {
  return request({
    url: 'api/powers/delete?id=' + id,
    method: 'get'
  })
}

export default { queryPower, getPower, createPower, updatePower, deletePower }
