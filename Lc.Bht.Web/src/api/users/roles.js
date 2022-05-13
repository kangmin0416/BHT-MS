import request from '@/utils/request'

// 获取所有的Role
export function queryRole(data) {
  return request({
    url: 'api/roles/query',
    method: 'post',
    data
  })
}

export function getRole(id) {
  return request({
    url: 'api/roles/get?id=' + id,
    method: 'get'
  })
}
export function getRoles() {
  return request({
    url: 'api/roles/get',
    method: 'get'
  })
}

export function createRole(data) {
  return request({
    url: 'api/roles/create',
    method: 'post',
    data
  })
}

export function updateRole(data) {
  return request({
    url: 'api/roles/update',
    method: 'post',
    data
  })
}

export function deleteRole(id) {
  return request({
    url: 'api/roles/delete?id=' + id,
    method: 'get'
  })
}

export default { queryRole, getRole, getRoles, createRole, updateRole, deleteRole }
