import request from '@/utils/request'

export function getUsers() {
  return request({
    url: 'api/users/get',
    method: 'get'
  })
}
export function queryUsers(data) {
  return request({
    url: 'api/users/query',
    method: 'post',
    data
  })
}

export function createUser(data) {
  return request({
    url: 'api/users/create',
    method: 'post',
    data
  })
}

export function updateUser(data) {
  return request({
    url: 'api/users/update',
    method: 'post',
    data
  })
}

export function deleteUsers(data) {
  return request({
    url: 'api/users/delete',
    method: 'post',
    data
  })
}

export function enableUsers(data) {
  return request({
    url: 'api/users/enable',
    method: 'post',
    data
  })
}

export function resetPassword(data) {
  return request({
    url: 'api/users/resetPassword',
    method: 'post',
    data
  })
}

export default { getUsers, createUser, updateUser, deleteUsers, queryUsers, enableUsers, resetPassword }

